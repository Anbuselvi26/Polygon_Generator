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

        private void generateButton_Click(object sender, EventArgs e)
        {
            int minVertices = (int)minVertexRangeNumericUpDown.Value;
            int maxVertices = (int)maxVertexRangeNumericUpDown.Value;

            int numPolygons = (int)numPolygonsNumericUpDown.Value;
            float minCoordinateValue = (float)minCoordinateValueNumericUpDown.Value;
            float maxCoordinateValue = (float)maxCoordinateValueNumericUpDown.Value;

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
        }

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

        private bool IsPolygonIntersecting(List<Vector2> vertices)
        {
            // Implement a polygon intersection check here

            // In this example, we are not implementing the intersection check,
            // but you can use an existing algorithm or library to determine if the polygon is intersecting.

            // Returning false as a placeholder
            return false;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is string filePath)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "CSV Files (*.csv)|*.csv",
                    Title = "Save CSV File",
                    FileName = System.IO.Path.GetFileName(filePath),
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    File.Copy(filePath, saveFileDialog.FileName);
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create an instance of the OtherForm
            PolygonGenerator Generator = new PolygonGenerator();

            // Show the OtherForm
            Generator.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

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
    }
}
