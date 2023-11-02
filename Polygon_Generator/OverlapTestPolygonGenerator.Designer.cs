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
        private FlowLayoutPanel flowLayoutPanel;


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
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            Clear = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)minVertexRangeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxVertexRangeNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPolygonsNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minCoordinateValueNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)maxCoordinateValueNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // generateButton
            // 
            generateButton.Location = new Point(73, 403);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(192, 28);
            generateButton.TabIndex = 9;
            generateButton.Text = "Generate and Save Polygons";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // vertexRangeCheckBox
            // 
            vertexRangeCheckBox.AutoSize = true;
            vertexRangeCheckBox.Location = new Point(12, 161);
            vertexRangeCheckBox.Name = "vertexRangeCheckBox";
            vertexRangeCheckBox.Size = new Size(139, 19);
            vertexRangeCheckBox.TabIndex = 4;
            vertexRangeCheckBox.Text = "Custom Vertex Range";
            vertexRangeCheckBox.UseVisualStyleBackColor = true;
            vertexRangeCheckBox.CheckedChanged += vertexRangeCheckBox_CheckedChanged;
            // 
            // minVertexRangeNumericUpDown
            // 
            minVertexRangeNumericUpDown.Location = new Point(172, 200);
            minVertexRangeNumericUpDown.Name = "minVertexRangeNumericUpDown";
            minVertexRangeNumericUpDown.Size = new Size(52, 23);
            minVertexRangeNumericUpDown.TabIndex = 5;
            // 
            // maxVertexRangeNumericUpDown
            // 
            maxVertexRangeNumericUpDown.Location = new Point(172, 240);
            maxVertexRangeNumericUpDown.Name = "maxVertexRangeNumericUpDown";
            maxVertexRangeNumericUpDown.Size = new Size(52, 23);
            maxVertexRangeNumericUpDown.TabIndex = 6;
            // 
            // numPolygonsNumericUpDown
            // 
            numPolygonsNumericUpDown.Location = new Point(172, 319);
            numPolygonsNumericUpDown.Name = "numPolygonsNumericUpDown";
            numPolygonsNumericUpDown.Size = new Size(93, 23);
            numPolygonsNumericUpDown.TabIndex = 8;
            numPolygonsNumericUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // minCoordinateValueNumericUpDown
            // 
            minCoordinateValueNumericUpDown.Location = new Point(172, 59);
            minCoordinateValueNumericUpDown.Name = "minCoordinateValueNumericUpDown";
            minCoordinateValueNumericUpDown.Size = new Size(52, 23);
            minCoordinateValueNumericUpDown.TabIndex = 10;
            // 
            // maxCoordinateValueNumericUpDown
            // 
            maxCoordinateValueNumericUpDown.Location = new Point(172, 96);
            maxCoordinateValueNumericUpDown.Name = "maxCoordinateValueNumericUpDown";
            maxCoordinateValueNumericUpDown.Size = new Size(52, 23);
            maxCoordinateValueNumericUpDown.TabIndex = 11;
            // 
            // minVerticesLabel
            // 
            minVerticesLabel.Location = new Point(0, 0);
            minVerticesLabel.Name = "minVerticesLabel";
            minVerticesLabel.Size = new Size(88, 22);
            minVerticesLabel.TabIndex = 12;
            // 
            // maxVerticesLabel
            // 
            maxVerticesLabel.Location = new Point(0, 0);
            maxVerticesLabel.Name = "maxVerticesLabel";
            maxVerticesLabel.Size = new Size(88, 22);
            maxVerticesLabel.TabIndex = 13;
            // 
            // numPolygonsLabel
            // 
            numPolygonsLabel.AutoSize = true;
            numPolygonsLabel.Location = new Point(31, 321);
            numPolygonsLabel.Name = "numPolygonsLabel";
            numPolygonsLabel.Size = new Size(120, 15);
            numPolygonsLabel.TabIndex = 7;
            numPolygonsLabel.Text = "Number of Polygons:";
            // 
            // minCoordinateValueLabel
            // 
            minCoordinateValueLabel.Location = new Point(0, 0);
            minCoordinateValueLabel.Name = "minCoordinateValueLabel";
            minCoordinateValueLabel.Size = new Size(88, 22);
            minCoordinateValueLabel.TabIndex = 14;
            // 
            // maxCoordinateValueLabel
            // 
            maxCoordinateValueLabel.Location = new Point(0, 0);
            maxCoordinateValueLabel.Name = "maxCoordinateValueLabel";
            maxCoordinateValueLabel.Size = new Size(88, 22);
            maxCoordinateValueLabel.TabIndex = 15;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Location = new Point(525, 96);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(262, 276);
            flowLayoutPanel.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 16;
            label1.Text = "Number of vertices:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 98);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 17;
            label2.Text = "Maximum value";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 67);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 20;
            label5.Text = "Minimum value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 202);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 21;
            label3.Text = "Minimum value";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 242);
            label4.Name = "label4";
            label4.Size = new Size(93, 15);
            label4.TabIndex = 22;
            label4.Text = "Maximum value";
            // 
            // Clear
            // 
            Clear.Location = new Point(128, 506);
            Clear.Name = "Clear";
            Clear.Size = new Size(71, 28);
            Clear.TabIndex = 23;
            Clear.Text = "Clear ";
            Clear.UseVisualStyleBackColor = true;
            Clear.Click += Clear_Click;
            // 
            // button2
            // 
            button2.Location = new Point(94, 453);
            button2.Name = "button2";
            button2.Size = new Size(149, 28);
            button2.TabIndex = 25;
            button2.Text = "View Polygon Plotter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 581);
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
            Controls.Add(flowLayoutPanel);
            Name = "MainForm";
            Text = "Random Polygon Generator";
            Load += MainForm_Load;
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
        private Button button2;
    }
}