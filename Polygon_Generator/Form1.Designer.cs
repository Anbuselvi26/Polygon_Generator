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
            saveButton = new System.Windows.Forms.Button();
            browseButton = new System.Windows.Forms.Button();
            clearButton = new System.Windows.Forms.Button();
            undoButton = new System.Windows.Forms.Button();
            redoButton = new System.Windows.Forms.Button();
            showButton = new System.Windows.Forms.Button();
            vertexCountLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // saveButton
            // 
            saveButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            saveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            saveButton.Location = new System.Drawing.Point(492, 33);
            saveButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(103, 38);
            saveButton.TabIndex = 0;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += SaveButton_Click;
            // 
            // browseButton
            // 
            browseButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            browseButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            browseButton.Location = new System.Drawing.Point(383, 33);
            browseButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            browseButton.Name = "browseButton";
            browseButton.Size = new System.Drawing.Size(103, 38);
            browseButton.TabIndex = 1;
            browseButton.Text = "Browse";
            browseButton.UseVisualStyleBackColor = false;
            browseButton.Click += BrowseButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = System.Drawing.SystemColors.ActiveBorder;
            clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            clearButton.ForeColor = System.Drawing.Color.Black;
            clearButton.Location = new System.Drawing.Point(1022, 33);
            clearButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            clearButton.Name = "clearButton";
            clearButton.Size = new System.Drawing.Size(103, 38);
            clearButton.TabIndex = 2;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += ClearButton_Click;
            // 
            // undoButton
            // 
            undoButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            undoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            undoButton.Location = new System.Drawing.Point(625, 33);
            undoButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            undoButton.Name = "undoButton";
            undoButton.Size = new System.Drawing.Size(103, 38);
            undoButton.TabIndex = 3;
            undoButton.Text = "Undo";
            undoButton.UseVisualStyleBackColor = false;
            undoButton.Click += UndoButton_Click;
            // 
            // redoButton
            // 
            redoButton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            redoButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            redoButton.Location = new System.Drawing.Point(736, 33);
            redoButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            redoButton.Name = "redoButton";
            redoButton.Size = new System.Drawing.Size(103, 38);
            redoButton.TabIndex = 4;
            redoButton.Text = "Redo";
            redoButton.UseVisualStyleBackColor = false;
            redoButton.Click += RedoButton_Click;
            // 
            // showButton
            // 
            showButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            showButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            showButton.Location = new System.Drawing.Point(846, 33);
            showButton.Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
            showButton.Name = "showButton";
            showButton.Size = new System.Drawing.Size(103, 38);
            showButton.TabIndex = 5;
            showButton.Text = "Show";
            showButton.UseVisualStyleBackColor = false;
            showButton.Click += ShowButton_Click;
            // 
            // vertexCountLabel
            // 
            vertexCountLabel.AutoSize = true;
            vertexCountLabel.Location = new System.Drawing.Point(1290, 50);
            vertexCountLabel.Margin = new System.Windows.Forms.Padding(15, 0, 15, 0);
            vertexCountLabel.Name = "vertexCountLabel";
            vertexCountLabel.Size = new System.Drawing.Size(25, 55);
            vertexCountLabel.TabIndex = 50;
            vertexCountLabel.Text = " ";
            // 
            // PolygonGenerator
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1924, 1007);
            Controls.Add(showButton);
            Controls.Add(redoButton);
            Controls.Add(undoButton);
            Controls.Add(clearButton);
            Controls.Add(browseButton);
            Controls.Add(saveButton);
            Controls.Add(vertexCountLabel);
            Margin = new System.Windows.Forms.Padding(5, 9, 5, 9);
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
    }
}

