namespace StudentForYou
{
    partial class AddSubjectForm
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
            this.AddSubjectButton = new System.Windows.Forms.Button();
            this.CancelAddSubjectButton = new System.Windows.Forms.Button();
            this.SubjectDescriptionBox = new System.Windows.Forms.TextBox();
            this.SubjectDifficultyTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.SubjectDescriptionLabel = new System.Windows.Forms.Label();
            this.SubjectNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddSubjectButton
            // 
            this.AddSubjectButton.Location = new System.Drawing.Point(87, 396);
            this.AddSubjectButton.Name = "AddSubjectButton";
            this.AddSubjectButton.Size = new System.Drawing.Size(228, 23);
            this.AddSubjectButton.TabIndex = 0;
            this.AddSubjectButton.Text = "Add Subject";
            this.AddSubjectButton.UseVisualStyleBackColor = true;
            this.AddSubjectButton.Click += new System.EventHandler(this.AddSubjectClick);
            // 
            // CancelAddSubjectButton
            // 
            this.CancelAddSubjectButton.Location = new System.Drawing.Point(498, 396);
            this.CancelAddSubjectButton.Name = "CancelAddSubjectButton";
            this.CancelAddSubjectButton.Size = new System.Drawing.Size(264, 28);
            this.CancelAddSubjectButton.TabIndex = 1;
            this.CancelAddSubjectButton.Text = "Cancel";
            this.CancelAddSubjectButton.UseVisualStyleBackColor = true;
            this.CancelAddSubjectButton.Click += new System.EventHandler(this.CancelAddSubjectButton_Click);
            // 
            // SubjectDescriptionBox
            // 
            this.SubjectDescriptionBox.Location = new System.Drawing.Point(130, 120);
            this.SubjectDescriptionBox.Multiline = true;
            this.SubjectDescriptionBox.Name = "SubjectDescriptionBox";
            this.SubjectDescriptionBox.Size = new System.Drawing.Size(631, 113);
            this.SubjectDescriptionBox.TabIndex = 2;
            // 
            // SubjectDifficultyTextBox
            // 
            this.SubjectDifficultyTextBox.Location = new System.Drawing.Point(131, 309);
            this.SubjectDifficultyTextBox.Name = "SubjectDifficultyTextBox";
            this.SubjectDifficultyTextBox.Size = new System.Drawing.Size(99, 22);
            this.SubjectDifficultyTextBox.TabIndex = 3;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(130, 46);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(632, 22);
            this.CourseNameTextBox.TabIndex = 4;
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.Location = new System.Drawing.Point(32, 309);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(70, 23);
            this.DifficultyLabel.TabIndex = 5;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // SubjectDescriptionLabel
            // 
            this.SubjectDescriptionLabel.Location = new System.Drawing.Point(32, 123);
            this.SubjectDescriptionLabel.Name = "SubjectDescriptionLabel";
            this.SubjectDescriptionLabel.Size = new System.Drawing.Size(92, 23);
            this.SubjectDescriptionLabel.TabIndex = 6;
            this.SubjectDescriptionLabel.Text = "Description";
            // 
            // SubjectNameLabel
            // 
            this.SubjectNameLabel.Location = new System.Drawing.Point(19, 45);
            this.SubjectNameLabel.Name = "SubjectNameLabel";
            this.SubjectNameLabel.Size = new System.Drawing.Size(105, 23);
            this.SubjectNameLabel.TabIndex = 7;
            this.SubjectNameLabel.Text = "Course Name";
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SubjectNameLabel);
            this.Controls.Add(this.SubjectDescriptionLabel);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.CourseNameTextBox);
            this.Controls.Add(this.SubjectDifficultyTextBox);
            this.Controls.Add(this.SubjectDescriptionBox);
            this.Controls.Add(this.CancelAddSubjectButton);
            this.Controls.Add(this.AddSubjectButton);
            this.Name = "AddSubjectForm";
            this.Text = "Add Subject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddSubjectButton;
        private System.Windows.Forms.Button CancelAddSubjectButton;
        private System.Windows.Forms.TextBox SubjectDescriptionBox;
        private System.Windows.Forms.TextBox SubjectDifficultyTextBox;
        private System.Windows.Forms.TextBox CourseNameTextBox;
        private System.Windows.Forms.Label DifficultyLabel;
        private System.Windows.Forms.Label SubjectDescriptionLabel;
        private System.Windows.Forms.Label SubjectNameLabel;
    }
}