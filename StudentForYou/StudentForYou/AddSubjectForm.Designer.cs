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
            this.CourseNameTextBox = new System.Windows.Forms.TextBox();
            this.roundPicturebox1 = new StudentForYou.RoundPicturebox();
            this.CourseDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DifficultyTextBox = new System.Windows.Forms.TextBox();
            this.CourseNameLabel = new System.Windows.Forms.Label();
            this.CourseDescriptionLabel = new System.Windows.Forms.Label();
            this.DifficultyLabel = new System.Windows.Forms.Label();
            this.SaveSubjectButton = new StudentForYou.RoundedButton();
            this.CancelAddSubjectButton = new StudentForYou.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(568, 205);
            this.CourseNameTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(2631, 38);
            this.CourseNameTextBox.TabIndex = 0;
            this.CourseNameTextBox.TextChanged += new System.EventHandler(this.CourseNameTextBox_TextChanged);
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Location = new System.Drawing.Point(896, 267);
            this.roundPicturebox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(267, 119);
            this.roundPicturebox1.TabIndex = 1;
            this.roundPicturebox1.TabStop = false;
            // 
            // CourseDescriptionTextBox
            // 
            this.CourseDescriptionTextBox.Location = new System.Drawing.Point(568, 298);
            this.CourseDescriptionTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CourseDescriptionTextBox.Multiline = true;
            this.CourseDescriptionTextBox.Name = "CourseDescriptionTextBox";
            this.CourseDescriptionTextBox.Size = new System.Drawing.Size(2631, 731);
            this.CourseDescriptionTextBox.TabIndex = 2;
            this.CourseDescriptionTextBox.TextChanged += new System.EventHandler(this.CourseDescriptionTextBox_TextChanged);
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.Location = new System.Drawing.Point(568, 1145);
            this.DifficultyTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(353, 38);
            this.DifficultyTextBox.TabIndex = 3;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(216, 205);
            this.CourseNameLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(188, 32);
            this.CourseNameLabel.TabIndex = 4;
            this.CourseNameLabel.Text = "Course Name";
            // 
            // CourseDescriptionLabel
            // 
            this.CourseDescriptionLabel.AutoSize = true;
            this.CourseDescriptionLabel.Location = new System.Drawing.Point(216, 305);
            this.CourseDescriptionLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CourseDescriptionLabel.Name = "CourseDescriptionLabel";
            this.CourseDescriptionLabel.Size = new System.Drawing.Size(256, 32);
            this.CourseDescriptionLabel.TabIndex = 5;
            this.CourseDescriptionLabel.Text = "Course Description";
            this.CourseDescriptionLabel.Click += new System.EventHandler(this.CourseDescriptionTextBox_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(243, 1152);
            this.DifficultyLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(124, 32);
            this.DifficultyLabel.TabIndex = 6;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // SaveSubjectButton
            // 
            this.SaveSubjectButton.Location = new System.Drawing.Point(568, 1405);
            this.SaveSubjectButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.SaveSubjectButton.Name = "SaveSubjectButton";
            this.SaveSubjectButton.Size = new System.Drawing.Size(517, 124);
            this.SaveSubjectButton.TabIndex = 7;
            this.SaveSubjectButton.Text = "Save";
            this.SaveSubjectButton.UseVisualStyleBackColor = true;
            this.SaveSubjectButton.Click += new System.EventHandler(this.SaveSubjectButton_Click);
            // 
            // CancelAddSubjectButton
            // 
            this.CancelAddSubjectButton.Location = new System.Drawing.Point(2600, 1405);
            this.CancelAddSubjectButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CancelAddSubjectButton.Name = "CancelAddSubjectButton";
            this.CancelAddSubjectButton.Size = new System.Drawing.Size(517, 124);
            this.CancelAddSubjectButton.TabIndex = 8;
            this.CancelAddSubjectButton.Text = "Cancel";
            this.CancelAddSubjectButton.UseVisualStyleBackColor = true;
            this.CancelAddSubjectButton.Click += new System.EventHandler(this.CancelAddSubjectButton_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3328, 1698);
            this.Controls.Add(this.CancelAddSubjectButton);
            this.Controls.Add(this.SaveSubjectButton);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.CourseDescriptionLabel);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.DifficultyTextBox);
            this.Controls.Add(this.CourseDescriptionTextBox);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.CourseNameTextBox);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "AddSubjectForm";
            this.Text = "StudentForYou";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundPicturebox roundPicturebox1;
        private System.Windows.Forms.Label CourseNameLabel;
        private System.Windows.Forms.Label CourseDescriptionLabel;
        private System.Windows.Forms.Label DifficultyLabel;
        private RoundedButton SaveSubjectButton;
        private RoundedButton CancelAddSubjectButton;
        public System.Windows.Forms.TextBox CourseNameTextBox;
        public System.Windows.Forms.TextBox CourseDescriptionTextBox;
        public System.Windows.Forms.TextBox DifficultyTextBox;
    }
}