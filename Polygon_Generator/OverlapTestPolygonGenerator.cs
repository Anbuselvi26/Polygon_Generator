using polygon;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace RandomPolygonGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //  After getting input parameter values from user and when user clicks generate button
        //  This method creates random polygon csv data files and store them in a folder
        private void generateButton_Click(object sender, EventArgs e)
        {
            int minVertices = (int)minVertexRangeNumericUpDown.Value;
            int maxVertices = (int)maxVertexRangeNumericUpDown.Value;

            int numPolygons = (int)numPolygonsNumericUpDown.Value;
            float minCoordinateValue = (float)minCoordinateValueNumericUpDown.Value;
            float maxCoordinateValue = (float)maxCoordinateValueNumericUpDown.Value;

            //  Condition for polygon vertex minimum range
            if (minVertexRangeNumericUpDown.Value < 3)
            {
                MessageBox.Show($"Polygon should have a minimum of 3 vertices.");
            }

            //  Condition for polygon vertex and coordinate min should be less than maximum 
            if (minVertexRangeNumericUpDown.Value > maxVertexRangeNumericUpDown.Value ||
            minCoordinateValueNumericUpDown.Value > maxCoordinateValueNumericUpDown.Value)
            {
                MessageBox.Show($"Input maximum value should be greater than minimum value.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //  Condition for the parameters should be in positive numbers
            else if (minVertexRangeNumericUpDown.Value >= 3 &&
            maxVertexRangeNumericUpDown.Value >= minVertexRangeNumericUpDown.Value &
            numPolygonsNumericUpDown.Value >= 0 &&
            minCoordinateValueNumericUpDown.Value >= 0 &&
            maxCoordinateValueNumericUpDown.Value >= minCoordinateValueNumericUpDown.Value)
            {
                Random random = new Random();

                string folderPath = CreateFolderOnDesktop("GeneratedPolygons"); // Create a folder for saving the files

                for (int i = 0; i < numPolygons; i++)
                {
                    List<string> polygonCoordinates = GenerateNonIntersectingPolygon(minVertices, maxVertices, minCoordinateValue, maxCoordinateValue, random);

                    string csvFileName = $"polygon_{i + 1}.csv";
                    string csvFilePath = Path.Combine(folderPath, csvFileName);

                    File.WriteAllLines(csvFilePath, polygonCoordinates);
                }

                MessageBox.Show($"Non-intersecting polygons generated and saved in the folder:\n{folderPath}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (var folderDialog = new FolderBrowserDialog())
                {
                    if (folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFolder = folderDialog.SelectedPath;

                        // Get all files with the .csv extension in the selected folder
                        string[] csvFiles = Directory.GetFiles(selectedFolder, "*.csv");

                        if (csvFiles.Length == 0)
                        {
                            MessageBox.Show("No CSV files found in the selected folder.");
                            return;
                        }

                        if (csvFiles.Length < 2)
                        {
                            MessageBox.Show("At least two CSV files are required to pair.");
                            return;
                        }

                        List<string> pairedFiles = new List<string>();

                        // Generate pairs of CSV files
                        for (int i = 0; i < csvFiles.Length; i++)
                        {
                            for (int j = i + 1; j < csvFiles.Length; j++)
                            {
                                pairedFiles.Add(csvFiles[i]);
                                pairedFiles.Add(csvFiles[j]);
                            }
                        }

                        // Display the paired CSV files
                        fileListListBox.Items.Clear();
                        fileListListBox.Items.AddRange(pairedFiles.ToArray());
                    }
                }
            }
        }

        //  This methods creates a folder on desktop to save the csv files that are generated
        private string CreateFolderOnDesktop(string folderName)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, folderName);

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            return folderPath;
        }

        
        // This event is triggered when an item is selected in the fileListListBox
        // The code is designed to read the contents of a selected CSV file, extract the X, Y coordinates of polygons from the CSV file
        // Then draw those polygons on a PictureBox
        private void fileListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFile = fileListListBox.SelectedItem as string;

            if (selectedFile != null)
            {
                // Read the CSV file and extract the X, Y coordinates of the polygons
                List<Point[]> polygons = new List<Point[]>();
                using (var reader = new StreamReader(selectedFile))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        if (values.Length % 2 == 0)
                        {
                            var polygon = new Point[values.Length / 2];
                            for (int i = 0; i < values.Length; i += 2)
                            {
                                int x = int.Parse(values[i]);
                                int y = int.Parse(values[i + 1]);
                                polygon[i / 2] = new Point(x, y);
                            }
                            polygons.Add(polygon);
                        }
                    }
                }

                using (var bmp = new Bitmap(pictureBox.Width, pictureBox.Height))
                using (var graphics = Graphics.FromImage(bmp))
                {
                    graphics.Clear(Color.White);

                    foreach (var polygon in polygons)
                    {
                        graphics.DrawPolygon(Pens.Black, polygon);
                    }

                    // Display the image in the PictureBox
                    pictureBox.Image = bmp;
                }
            }
        }

        //  This method generates non-intersecting polygons with a random number of vertices and random coordinates within specified ranges
        private List<string> GenerateNonIntersectingPolygon(int minVertices, int maxVertices, float minCoordinateValue, float maxCoordinateValue, Random random)
        {
            List<Vector2> vertices = new List<Vector2>();

            int numVertices = random.Next(minVertices, maxVertices + 1); // Randomly choose the number of vertices within the specified range

            for (int j = 0; j < numVertices; j++)
            {
                float x = (float)(random.NextDouble() * (maxCoordinateValue - minCoordinateValue) + minCoordinateValue);
                float y = (float)(random.NextDouble() * (maxCoordinateValue - minCoordinateValue) + minCoordinateValue);
                vertices.Add(new Vector2(x, y));
            }

            // Sort the vertices in counterclockwise order based on polar angle from the centroid
            Vector2 centroid = ComputeCentroid(vertices);
            vertices.Sort((a, b) => Math.Atan2(a.Y - centroid.Y, a.X - centroid.X).CompareTo(Math.Atan2(b.Y - centroid.Y, b.X - centroid.X)));

            List<string> polygonCoordinates = new List<string>();

            for (int j = 0; j < vertices.Count; j++)
            {
                polygonCoordinates.Add($"{vertices[j].X},{vertices[j].Y}");
            }

            return polygonCoordinates;
        }

        //   This method calculates the centroid of a polygon given a list of its vertices, represented as Vector2 objects
        //   The centroid is the geometric center of the polygon and is often used for various geometric calculations
        private Vector2 ComputeCentroid(List<Vector2> vertices)
        {
            float cx = 0f;
            float cy = 0f;

            foreach (var vertex in vertices)
            {
                cx += vertex.X;
                cy += vertex.Y;
            }

            cx /= vertices.Count;
            cy /= vertices.Count;

            return new Vector2(cx, cy);
        }

        //   This method shuffles the elements in an IList<T> (generic list) using the Fisher-Yates shuffle algorithm
        //   This algorithm randomly rearranges the elements in the list
        private void Shuffle<T>(IList<T> list, Random random)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        //  This method provides a constructor to initialize the X and Y values when creating a Vector2 instance
        //  This struct is commonly used to store and manipulate 2D coordinates in applications where such data is needed
        private struct Vector2
        {
            public float X;
            public float Y;

            public Vector2(float x, float y)
            {
                X = x;
                Y = y;
            }
        }

        private bool IsPolygonIntersecting(List<Vector2> vertices)
        {
            // Implement a polygon intersection check here

            // In this example, we are not implementing the intersection check,
            // but you can use an existing algorithm or library to determine if the polygon is intersecting.

            // Returning false as a placeholder
            return false;
        }

        //  Enables or disable the CheckBox by user input control
        private void vertexRangeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            minVertexRangeNumericUpDown.Enabled = vertexRangeCheckBox.Checked;
            maxVertexRangeNumericUpDown.Enabled = vertexRangeCheckBox.Checked;
        }

        // Clear the values in the NumericUpDown controls
        private void Clear_Click(object sender, EventArgs e)
        {
            minVertexRangeNumericUpDown.Value = 0;
            maxVertexRangeNumericUpDown.Value = 0;
            numPolygonsNumericUpDown.Value = 0;
            minCoordinateValueNumericUpDown.Value = 0;
            maxCoordinateValueNumericUpDown.Value = 0;
            fileListListBox.Items.Clear();
        }

        //  This method redirects to Polygon Plotter UI
        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the OtherForm
            PolygonGenerator Generator = new PolygonGenerator();

            // Show the OtherForm
            Generator.Show();
        }
    }
}