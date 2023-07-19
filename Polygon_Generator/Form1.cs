using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace polygon
{
    public partial class PolygonGenerator : Form
    {
        private const int AxisMargin = 30;
        private const int PointSize = 7;
        private bool isDragging = false;
        private int selectedIndex = -1;
        private const float MeasurementScale = 1f;
        private bool intersectionDetected = false;
        private PointF selectedPoint;
        private PointF mouseOffset;
        private List<PointF> points = new List<PointF>();
        private Stack<PointF> removedPoints = new Stack<PointF>();
        private float scaleX, scaleY;
        public PolygonGenerator()
        {
            InitializeComponent();
            MouseDown += PolygonGenerator_MouseDown;
            MouseMove += PolygonGenerator_MouseMove;
            MouseUp += PolygonGenerator_MouseUp;
            MouseClick += PolygonGenerator_MouseClick;
            Paint += PolygonGenerator_Paint;
            Resize += PolygonGenerator_Resize;
            SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            CalculateScaleFactor();
        }
        private void PolygonGenerator_Paint(object sender, PaintEventArgs e)
        {
            CalculateScaleFactor();
            DrawGraph(e.Graphics, true, scaleX, scaleY);
        }
        private void PolygonGenerator_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < points.Count; i++)
            {
                PointF scaledPoint = ScalePointToScreen(points[i]);
                float distanceX = e.X - scaledPoint.X;
                float distanceY = e.Y - scaledPoint.Y;

                if (Math.Sqrt(distanceX * distanceX + distanceY * distanceY) <= PointSize / 2)
                {
                    isDragging = true;
                    selectedIndex = i;
                    mouseOffset = new PointF(e.X - scaledPoint.X, e.Y - scaledPoint.Y);
                    break;
                }
            }
        }
        private void PolygonGenerator_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedIndex >= 0 && selectedIndex < points.Count)
            {
                float x = (e.X - AxisMargin) / scaleX;
                float y = (ClientSize.Height - AxisMargin - e.Y) / scaleY;

                PointF newPoint = new PointF(x, y);
                points[selectedIndex] = newPoint;
                Invalidate();
            }
        }
        private void PolygonGenerator_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            selectedIndex = -1;
        }
        private void PolygonGenerator_MouseClick(object sender, MouseEventArgs e)
        {
            if (points.Count >= 3)
            {
                PointF firstPoint = points[0];
                float scaleX = (ClientSize.Width - 2 * AxisMargin) / 50f;
                float scaleY = (ClientSize.Height - 2 * AxisMargin) / 30f;
                int firstX = (int)Math.Round(firstPoint.X * scaleX) + AxisMargin;
                int firstY = ClientSize.Height - (int)Math.Round(firstPoint.Y * scaleY) - AxisMargin;
                if (Math.Abs(e.X - firstX) <= PointSize / 2 && Math.Abs(e.Y - firstY) <= PointSize / 2)
                {
                    bool intersectionDetected = DoLinesIntersect();
                    if (intersectionDetected)
                    {
                        DialogResult result = MessageBox.Show("The lines intersect. Please draw non-intersecting lines.", "Intersection Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        if (result == DialogResult.OK)
                        {
                        }
                    }
                    else
                    {
                        Invalidate();
                    }
                    return;
                }
            }
            foreach (var point in points)
            {
                PointF scaledPoint = ScalePointToScreen(point);
                float scaleX = (ClientSize.Width - 2 * AxisMargin) / 50f;
                float scaleY = (ClientSize.Height - 2 * AxisMargin) / 30f;
                int x = (int)Math.Round(point.X * scaleX) + AxisMargin;
                int y = ClientSize.Height - (int)Math.Round(point.Y * scaleY) - AxisMargin;
                if (e.X >= x - PointSize / 2 && e.X <= x + PointSize / 2 &&
                    e.Y >= y - PointSize / 2 && e.Y <= y + PointSize / 2)
                {
                    isDragging = true;
                    selectedPoint = point;
                    break;
                }
            }
            if (!isDragging)
            {
                int maxX = ClientSize.Width - 2 * AxisMargin;
                int maxY = ClientSize.Height - 2 * AxisMargin;
                float scaleX = maxX / 50f;
                float scaleY = maxY / 30f;
                float x = (e.X - AxisMargin) / scaleX;
                float y = (maxY - (e.Y - AxisMargin)) / scaleY;
                points.Add(new PointF(x, y));
                removedPoints.Clear();
                if (DoLinesIntersect())
                {
                    MessageBox.Show("The lines intersect. Please draw non-intersecting lines.", "Intersection Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    points.RemoveAt(points.Count - 1);
                }
            }
            UpdateVertexCountLabel();
            Invalidate();
        }
        private void CalculateScaleFactor()
        {
            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int screenHeight = Screen.PrimaryScreen.Bounds.Height;
            scaleX = (screenWidth - 2 * AxisMargin) / 50f;  //scalefactor
            scaleY = (screenHeight - 2 * AxisMargin) / 30f;
        }
        private void PolygonGenerator_Resize(object sender, EventArgs e)
        {
            CalculateScaleFactor();
            Invalidate();
        }
        private PointF ScalePointToScreen(PointF point)
        {
            int x = (int)Math.Round(point.X * scaleX) + AxisMargin;
            int y = ClientSize.Height - (int)Math.Round(point.Y * scaleY) - AxisMargin;
            return new PointF(x, y);
        }
        private int ScaleSizeToScreen(int size, float scale)
        {
            return (int)Math.Round(size * scale);
        }
        private bool DoLinesIntersect(PointF p1, PointF p2, PointF p3, PointF p4)
        {
            if (Math.Max(p1.X, p2.X) < Math.Min(p3.X, p4.X) || Math.Min(p1.X, p2.X) > Math.Max(p3.X, p4.X) ||
                Math.Max(p1.Y, p2.Y) < Math.Min(p3.Y, p4.Y) || Math.Min(p1.Y, p2.Y) > Math.Max(p3.Y, p4.Y))
            {
                return false;
            }
            float denominator = (p4.Y - p3.Y) * (p2.X - p1.X) - (p4.X - p3.X) * (p2.Y - p1.Y);
            float numerator1 = (p4.X - p3.X) * (p1.Y - p3.Y) - (p4.Y - p3.Y) * (p1.X - p3.X);
            float numerator2 = (p2.X - p1.X) * (p1.Y - p3.Y) - (p2.Y - p1.Y) * (p1.X - p3.X);

            if (denominator == 0)
            {
                return numerator1 == 0 && numerator2 == 0;
            }
            float r = numerator1 / denominator;
            float s = numerator2 / denominator;
            return r >= 0 && r <= 1 && s >= 0 && s <= 1;
        }
        private bool DoLinesIntersect()
        {
            int count = points.Count;
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 2; j < count; j++)
                {
                    if (j == count - 1 && i == 0)
                        continue;
                    if (DoLinesIntersect(points[i], points[i + 1], points[j], points[(j + 1) % count]))
                        return true;
                }
            }
            return false;
        }
        private float CalculatePolygonArea(List<PointF> polygon)
        {
            int count = polygon.Count;
            float area = 0;

            for (int i = 0; i < count; i++)
            {
                PointF p1 = polygon[i];
                PointF p2 = polygon[(i + 1) % count];
                area += (p1.X * p2.Y) - (p1.Y * p2.X);
            }
            return Math.Abs(area / 2);
        }
        private void DrawGraph(Graphics g, bool drawAxisLines, float scaleX, float scaleY)
        {
            int width = ClientSize.Width;
            int height = ClientSize.Height;
            g.Clear(Color.White);

            bool intersectionDetected = DoLinesIntersect(); //check for intersection

            if (intersectionDetected)
            {
                MessageBox.Show("The lines intersect. Please draw non-intersecting lines.", "Intersection Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (points.Count > 1)
            {
                for (int i = 1; i < points.Count; i++)   //draw lines
                {
                    PointF prevPoint = ScalePointToScreen(points[i - 1]);
                    PointF currPoint = ScalePointToScreen(points[i]);
                    g.DrawLine(Pens.Blue, prevPoint, currPoint);
                }
                PointF firstPoint = ScalePointToScreen(points[0]);  //draw polygon
                PointF lastPoint = ScalePointToScreen(points[points.Count - 1]);
                g.DrawLine(Pens.Blue, lastPoint, firstPoint);

                float area = CalculatePolygonArea(points);  //area
                string areaText = $"Area: {area} sq units";
                SizeF areaTextSize = g.MeasureString(areaText, Font);
                g.DrawString(areaText, Font, Brushes.Black, (width - areaTextSize.Width) / 2, height - AxisMargin - areaTextSize.Height - 800);
            }
            if (drawAxisLines)
            {
                g.DrawLine(Pens.Black, AxisMargin, height - AxisMargin, width - AxisMargin, height - AxisMargin);
                g.DrawLine(Pens.Black, AxisMargin, height - AxisMargin, AxisMargin, AxisMargin);

                float intervalX = 1f;
                for (int i = 1; i <= 50; i++)
                {
                    int x = (int)Math.Round(i * scaleX * intervalX) + AxisMargin;
                    int y = height - AxisMargin;
                    g.DrawLine(Pens.Black, x, y - 5, x, y + 5);
                    g.DrawString(i.ToString(), Font, Brushes.Black, x, y + 5);
                }
                //
                float intervalY = 1f;
                for (int i = 1; i <= 30; i++)
                {
                    int x = AxisMargin;
                    int y = height - (int)Math.Round(i * scaleY * intervalY) - AxisMargin;
                    g.DrawLine(Pens.Black, x - 5, y, x + 5, y);
                    g.DrawString(i.ToString(), Font, Brushes.Black, x - 20, y - 10);
                }
                g.DrawString("0", Font, Brushes.Black, AxisMargin - 20, height - AxisMargin + 5);
                g.DrawString("X", Font, Brushes.Black, width - AxisMargin - 10, height - AxisMargin - 20);
                g.DrawString("Y", Font, Brushes.Black, AxisMargin + 5, AxisMargin - 20);

                g.DrawString("0", Font, Brushes.Black, AxisMargin - 20, height - AxisMargin + 5);
                g.DrawString("X", Font, Brushes.Black, width - AxisMargin - 10, height - AxisMargin - 20);
                g.DrawString("Y", Font, Brushes.Black, AxisMargin + 5, AxisMargin - 20);
            }
            foreach (var point in points)
            {
                PointF scaledPoint = ScalePointToScreen(point);
                g.FillEllipse(Brushes.Red, scaledPoint.X - PointSize / 2, scaledPoint.Y - PointSize / 2, PointSize, PointSize);
            }
        }
        private int GetPolygonVertexCount()
        {
            return points.Count;
        }
        private void UpdateVertexCountLabel()
        {
            int vertexCount = GetPolygonVertexCount();
            vertexCountLabel.Text = $"  Vertex Count: {vertexCount}";
        }
        private bool IsPolygon()
        {
            return points.Count > 2 && !DoLinesIntersect();
        }
        private void LoadPointsFromCSV(string filePath)
        {
            points.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] coordinates = line.Split(',');
                    if (coordinates.Length == 2 && float.TryParse(coordinates[0], out float x) && float.TryParse(coordinates[1], out float y))
                    {
                        points.Add(new PointF(x / MeasurementScale, y / MeasurementScale));
                    }
                }
            }
            removedPoints.Clear();
            Invalidate();
        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files|*.csv";
            openFileDialog.Title = "Browse CSV file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                LoadPointsFromCSV(filePath);
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsPolygon())
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files|*.csv";
                saveFileDialog.Title = "Save Polygon Points";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    SavePolygonToCSV(filePath);
                }
            }
            else
            {
                MessageBox.Show("Not a polygon.");
            }
        }
        private void SavePolygonToCSV(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"X-axis,Y-axis");
                for (int i = 0; i < points.Count; i++)
                {
                    writer.WriteLine($"{points[i].X * MeasurementScale},{points[i].Y * MeasurementScale}");
                }
            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            points.Clear();
            removedPoints.Clear();
            vertexCountLabel.Text = " ";
            Invalidate();
        }
        private void UndoButton_Click(object sender, EventArgs e)
        {
            if (points.Count > 0)
            {
                PointF lastPoint = points[points.Count - 1];
                points.RemoveAt(points.Count - 1);
                removedPoints.Push(lastPoint);
                Invalidate();
            }
        }
        private void RedoButton_Click(object sender, EventArgs e)
        {
            if (removedPoints.Count > 0)
            {
                PointF restoredPoint = removedPoints.Pop();
                points.Add(restoredPoint);
                Invalidate();
            }
        }
        private void ShowButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = CreateGraphics())
            {
                CalculateScaleFactor();
                g.Clear(Color.White);
                DrawGraph(g, true, scaleX, scaleY);
                foreach (var point in points)
                {
                    PointF scaledPoint = ScalePointToScreen(point);
                    string coordinates = $"({(int)point.X}, {(int)point.Y})";
                    SizeF labelSize = g.MeasureString(coordinates, Font);
                    PointF labelPosition = new PointF(scaledPoint.X - labelSize.Width / 2, scaledPoint.Y - labelSize.Height - 5);
                    g.FillRectangle(Brushes.Transparent, labelPosition.X, labelPosition.Y, labelSize.Width, labelSize.Height);
                    g.DrawString(coordinates, Font, Brushes.Black, labelPosition);
                }
                bool intersectionDetected = DoLinesIntersect();
                if (intersectionDetected)
                {
                    MessageBox.Show("The lines intersect. Please draw non-intersecting lines.", "Intersection Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}