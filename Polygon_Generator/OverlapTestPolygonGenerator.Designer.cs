namespace RandomPolygonGenerator
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private Button generateButton;
        private CheckBox vertexRangeCheckBox;
        private NumericUpDown minVertexRangeNumericUpDown;
        private NumericUpDown maxVertexRangeNumericUpDown;
        private NumericUpDown numPolygonsNumericUpDown;
        private NumericUpDown minCoordinateValueNumericUpDown;
        private NumericUpDown maxCoordinateValueNumericUpDown;
        private Label minVerticesLabel;
        private Label maxVerticesLabel;
        private Label numPolygonsLabel;
        private Label minCoordinateValueLabel;
        private Label maxCoordinateValueLabel;


        private void InitializeComponent()
        {
            generateButton = new Button();
            vertexRangeCheckBox = new CheckBox();
            minVertexRangeNumericUpDown = new NumericUpDown();
            maxVertexRangeNumericUpDown = new NumericUpDown();
            numPolygonsNumericUpDown = new NumericUpDown();
            minCoordinateValueNumericUpDown = new NumericUpDown();
            maxCoordinateValueNumericUpDown = new NumericUpDown();
            minVerticesLabel = new Label();
            maxVerticesLabel = new Label();
            numPolygonsLabel = new Label();
            minCoordinateValueLabel = new Label();
            maxCoordinateValueLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            Clear = new Button();
            button1 = new Button();
            button2 = new Button();
            fileListListBox = new ListBox();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)minVertexRangeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxVertexRangeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPolygonsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minCoordinateValueNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxCoordinateValueNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Location = new Point(105, 501);
            generateButton.Margin = new Padding(4, 5, 4, 5);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(274, 47);
            generateButton.TabIndex = 9;
            generateButton.Text = "Generate and Save Polygons";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // vertexRangeCheckBox
            // 
            vertexRangeCheckBox.AutoSize = true;
            vertexRangeCheckBox.Location = new Point(17, 229);
            vertexRangeCheckBox.Margin = new Padding(4, 5, 4, 5);
            vertexRangeCheckBox.Name = "vertexRangeCheckBox";
            vertexRangeCheckBox.Size = new Size(208, 29);
            vertexRangeCheckBox.TabIndex = 4;
            vertexRangeCheckBox.Text = "Custom Vertex Range";
            vertexRangeCheckBox.UseVisualStyleBackColor = true;
            vertexRangeCheckBox.CheckedChanged += vertexRangeCheckBox_CheckedChanged;
            // 
            // minVertexRangeNumericUpDown
            // 
            minVertexRangeNumericUpDown.Location = new Point(246, 106);
            minVertexRangeNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            minVertexRangeNumericUpDown.Name = "minVertexRangeNumericUpDown";
            minVertexRangeNumericUpDown.Size = new Size(74, 31);
            minVertexRangeNumericUpDown.TabIndex = 5;
            minVertexRangeNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // maxVertexRangeNumericUpDown
            // 
            maxVertexRangeNumericUpDown.Location = new Point(246, 157);
            maxVertexRangeNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            maxVertexRangeNumericUpDown.Name = "maxVertexRangeNumericUpDown";
            maxVertexRangeNumericUpDown.Size = new Size(74, 31);
            maxVertexRangeNumericUpDown.TabIndex = 6;
            maxVertexRangeNumericUpDown.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // numPolygonsNumericUpDown
            // 
            numPolygonsNumericUpDown.Location = new Point(246, 398);
            numPolygonsNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            numPolygonsNumericUpDown.Name = "numPolygonsNumericUpDown";
            numPolygonsNumericUpDown.Size = new Size(133, 31);
            numPolygonsNumericUpDown.TabIndex = 8;
            numPolygonsNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // minCoordinateValueNumericUpDown
            // 
            minCoordinateValueNumericUpDown.Location = new Point(246, 273);
            minCoordinateValueNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            minCoordinateValueNumericUpDown.Name = "minCoordinateValueNumericUpDown";
            minCoordinateValueNumericUpDown.Size = new Size(74, 31);
            minCoordinateValueNumericUpDown.TabIndex = 10;
            // 
            // maxCoordinateValueNumericUpDown
            // 
            maxCoordinateValueNumericUpDown.Location = new Point(246, 333);
            maxCoordinateValueNumericUpDown.Margin = new Padding(4, 5, 4, 5);
            maxCoordinateValueNumericUpDown.Name = "maxCoordinateValueNumericUpDown";
            maxCoordinateValueNumericUpDown.Size = new Size(74, 31);
            maxCoordinateValueNumericUpDown.TabIndex = 11;
            // 
            // minVerticesLabel
            // 
            minVerticesLabel.Location = new Point(0, 0);
            minVerticesLabel.Margin = new Padding(4, 0, 4, 0);
            minVerticesLabel.Name = "minVerticesLabel";
            minVerticesLabel.Size = new Size(126, 37);
            minVerticesLabel.TabIndex = 12;
            // 
            // maxVerticesLabel
            // 
            maxVerticesLabel.Location = new Point(0, 0);
            maxVerticesLabel.Margin = new Padding(4, 0, 4, 0);
            maxVerticesLabel.Name = "maxVerticesLabel";
            maxVerticesLabel.Size = new Size(126, 37);
            maxVerticesLabel.TabIndex = 13;
            // 
            // numPolygonsLabel
            // 
            numPolygonsLabel.AutoSize = true;
            numPolygonsLabel.Location = new Point(44, 400);
            numPolygonsLabel.Margin = new Padding(4, 0, 4, 0);
            numPolygonsLabel.Name = "numPolygonsLabel";
            numPolygonsLabel.Size = new Size(181, 25);
            numPolygonsLabel.TabIndex = 7;
            numPolygonsLabel.Text = "Number of Polygons:";
            // 
            // minCoordinateValueLabel
            // 
            minCoordinateValueLabel.Location = new Point(0, 0);
            minCoordinateValueLabel.Margin = new Padding(4, 0, 4, 0);
            minCoordinateValueLabel.Name = "minCoordinateValueLabel";
            minCoordinateValueLabel.Size = new Size(126, 37);
            minCoordinateValueLabel.TabIndex = 14;
            // 
            // maxCoordinateValueLabel
            // 
            maxCoordinateValueLabel.Location = new Point(0, 0);
            maxCoordinateValueLabel.Margin = new Padding(4, 0, 4, 0);
            maxCoordinateValueLabel.Name = "maxCoordinateValueLabel";
            maxCoordinateValueLabel.Size = new Size(126, 37);
            maxCoordinateValueLabel.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 16;
            label1.Text = "Number of vertices:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 163);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 25);
            label2.TabIndex = 17;
            label2.Text = "Maximum value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 112);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 20;
            label5.Text = "Minimum value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 279);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 21;
            label3.Text = "Minimum value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(74, 333);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 22;
            label4.Text = "Maximum value";
            // 
            // Clear
            // 
            Clear.Location = new Point(317, 593);
            Clear.Margin = new Padding(4, 5, 4, 5);
            Clear.Name = "Clear";
            Clear.Size = new Size(101, 47);
            Clear.TabIndex = 23;
            Clear.Text = "Clear ";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button1
            // 
            /*button1.Location = new Point(44, 793);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button2";
            button1.Size = new Size(213, 47);
            button1.TabIndex = 25;
            button1.Text = "Select Folder";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BrowseButton_Click;*/
            // 
            // button2
            // 
            button2.Location = new Point(44, 593);
            button2.Margin = new Padding(4, 5, 4, 5);
            button2.Name = "button2";
            button2.Size = new Size(213, 47);
            button2.TabIndex = 25;
            button2.Text = "View Polygon Plotter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // fileListListBox
            // 
            fileListListBox.ItemHeight = 15;
            fileListListBox.Location = new Point(471, 100);
            fileListListBox.Name = "fileListListBox";
            fileListListBox.Size = new Size(600, 700);
            fileListListBox.TabIndex = 1;
            fileListListBox.SelectedIndexChanged += fileListListBox_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            /*pictureBox.Location = new Point(890, 79);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(508, 604);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;*/
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 900);
            Controls.Add(pictureBox);
            Controls.Add(fileListListBox);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(Clear);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(generateButton);
            Controls.Add(vertexRangeCheckBox);
            Controls.Add(minVertexRangeNumericUpDown);
            Controls.Add(maxVertexRangeNumericUpDown);
            Controls.Add(numPolygonsNumericUpDown);
            Controls.Add(minCoordinateValueNumericUpDown);
            Controls.Add(maxCoordinateValueNumericUpDown);
            Controls.Add(minVerticesLabel);
            Controls.Add(maxVerticesLabel);
            Controls.Add(numPolygonsLabel);
            Controls.Add(minCoordinateValueLabel);
            Controls.Add(maxCoordinateValueLabel);
            Margin = new Padding(4, 5, 4, 5);
            Name = "MainForm";
            Text = "Test Polygon Generator";
            ((System.ComponentModel.ISupportInitialize)minVertexRangeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxVertexRangeNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPolygonsNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)minCoordinateValueNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)maxCoordinateValueNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Label label4;
        private Button Clear;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox;
        private ListBox fileListListBox; 
    }
}