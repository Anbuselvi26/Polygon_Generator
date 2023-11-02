using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace polygon
{
    partial class PolygonGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            saveButton = new Button();
            browseButton = new Button();
            clearButton = new Button();
            undoButton = new Button();
            redoButton = new Button();
            showButton = new Button();
            vertexCountLabel = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = SystemColors.ScrollBar;
            saveButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            saveButton.Location = new Point(492, 33);
            saveButton.Margin = new Padding(5, 9, 5, 9);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(103, 38);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // browseButton
            // 
            browseButton.BackColor = SystemColors.ScrollBar;
            browseButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            browseButton.Location = new Point(383, 33);
            browseButton.Margin = new Padding(5, 9, 5, 9);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(103, 38);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += BrowseButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = SystemColors.ActiveBorder;
            clearButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clearButton.ForeColor = Color.Black;
            clearButton.Location = new Point(1022, 33);
            clearButton.Margin = new Padding(5, 9, 5, 9);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(103, 38);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // undoButton
            // 
            undoButton.BackColor = SystemColors.ActiveCaption;
            undoButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            undoButton.Location = new Point(625, 33);
            undoButton.Margin = new Padding(5, 9, 5, 9);
            undoButton.Name = "undoButton";
            undoButton.Size = new Size(103, 38);
            undoButton.TabIndex = 3;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = false;
            undoButton.Click += UndoButton_Click;
            // 
            // redoButton
            // 
            redoButton.BackColor = SystemColors.ButtonShadow;
            redoButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            redoButton.Location = new Point(736, 33);
            redoButton.Margin = new Padding(5, 9, 5, 9);
            redoButton.Name = "redoButton";
            redoButton.Size = new Size(103, 38);
            redoButton.TabIndex = 4;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = false;
            redoButton.Click += RedoButton_Click;
            // 
            // showButton
            // 
            showButton.BackColor = SystemColors.ActiveCaption;
            showButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            showButton.Location = new Point(846, 33);
            showButton.Margin = new Padding(5, 9, 5, 9);
            showButton.Name = "showButton";
            showButton.Size = new Size(103, 38);
            showButton.TabIndex = 5;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += ShowButton_Click;
            // 
            // vertexCountLabel
            // 
            vertexCountLabel.AutoSize = true;
            vertexCountLabel.Location = new Point(1150, 50);
            vertexCountLabel.Margin = new Padding(15, 0, 15, 0);
            vertexCountLabel.Name = "vertexCountLabel";
            vertexCountLabel.Size = new Size(10, 15);
            vertexCountLabel.TabIndex = 50;
            vertexCountLabel.Text = " ";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(1216, 19);
            button1.Margin = new Padding(5, 9, 5, 9);
            button1.Name = "button1";
            button1.Size = new Size(163, 65);
            button1.TabIndex = 51;
            button1.Text = "View Test Polygon Generator";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PolygonGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1007);
            Controls.Add(button1);
            Controls.Add(showButton);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(clearButton);
            Controls.Add(browseButton);
            Controls.Add(saveButton);
            Controls.Add(vertexCountLabel);
            Margin = new Padding(5, 9, 5, 9);
            Name = "PolygonGenerator";
            Text = "Polygon Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Button browseButton;
        private Button clearButton;
        private Button undoButton;
        private Button redoButton;
        private Button showButton;
        private Label vertexCountLabel;
        private Button button1;
    }
}

