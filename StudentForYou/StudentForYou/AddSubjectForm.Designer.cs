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
            this.CourseNameTextBox.Location = new System.Drawing.Point(213, 86);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(989, 20);
            this.CourseNameTextBox.TabIndex = 0;
            this.CourseNameTextBox.TextChanged += new System.EventHandler(this.CourseNameTextBox_TextChanged);
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Location = new System.Drawing.Point(336, 112);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(100, 50);
            this.roundPicturebox1.TabIndex = 1;
            this.roundPicturebox1.TabStop = false;
            // 
            // CourseDescriptionTextBox
            // 
            this.CourseDescriptionTextBox.Location = new System.Drawing.Point(213, 125);
            this.CourseDescriptionTextBox.Multiline = true;
            this.CourseDescriptionTextBox.Name = "CourseDescriptionTextBox";
            this.CourseDescriptionTextBox.Size = new System.Drawing.Size(989, 309);
            this.CourseDescriptionTextBox.TabIndex = 2;
            this.CourseDescriptionTextBox.TextChanged += new System.EventHandler(this.CourseDescriptionTextBox_TextChanged);
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.Location = new System.Drawing.Point(213, 480);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(135, 20);
            this.DifficultyTextBox.TabIndex = 3;
            // 
            // CourseNameLabel
            // 
            this.CourseNameLabel.AutoSize = true;
            this.CourseNameLabel.Location = new System.Drawing.Point(81, 86);
            this.CourseNameLabel.Name = "CourseNameLabel";
            this.CourseNameLabel.Size = new System.Drawing.Size(71, 13);
            this.CourseNameLabel.TabIndex = 4;
            this.CourseNameLabel.Text = "Course Name";
            // 
            // CourseDescriptionLabel
            // 
            this.CourseDescriptionLabel.AutoSize = true;
            this.CourseDescriptionLabel.Location = new System.Drawing.Point(81, 128);
            this.CourseDescriptionLabel.Name = "CourseDescriptionLabel";
            this.CourseDescriptionLabel.Size = new System.Drawing.Size(96, 13);
            this.CourseDescriptionLabel.TabIndex = 5;
            this.CourseDescriptionLabel.Text = "Course Description";
            this.CourseDescriptionLabel.Click += new System.EventHandler(this.CourseDescriptionTextBox_Click);
            // 
            // DifficultyLabel
            // 
            this.DifficultyLabel.AutoSize = true;
            this.DifficultyLabel.Location = new System.Drawing.Point(91, 483);
            this.DifficultyLabel.Name = "DifficultyLabel";
            this.DifficultyLabel.Size = new System.Drawing.Size(47, 13);
            this.DifficultyLabel.TabIndex = 6;
            this.DifficultyLabel.Text = "Difficulty";
            // 
            // SaveSubjectButton
            // 
            this.SaveSubjectButton.Location = new System.Drawing.Point(213, 589);
            this.SaveSubjectButton.Name = "SaveSubjectButton";
            this.SaveSubjectButton.Size = new System.Drawing.Size(194, 52);
            this.SaveSubjectButton.TabIndex = 7;
            this.SaveSubjectButton.Text = "Save";
            this.SaveSubjectButton.UseVisualStyleBackColor = true;
            this.SaveSubjectButton.Click += new System.EventHandler(this.SaveSubjectButton_Click);
            // 
            // CancelAddSubjectButton
            // 
            this.CancelAddSubjectButton.Location = new System.Drawing.Point(975, 589);
            this.CancelAddSubjectButton.Name = "CancelAddSubjectButton";
            this.CancelAddSubjectButton.Size = new System.Drawing.Size(194, 52);
            this.CancelAddSubjectButton.TabIndex = 8;
            this.CancelAddSubjectButton.Text = "Cancel";
            this.CancelAddSubjectButton.UseVisualStyleBackColor = true;
            this.CancelAddSubjectButton.Click += new System.EventHandler(this.CancelAddSubjectButton_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.CancelAddSubjectButton);
            this.Controls.Add(this.SaveSubjectButton);
            this.Controls.Add(this.DifficultyLabel);
            this.Controls.Add(this.CourseDescriptionLabel);
            this.Controls.Add(this.CourseNameLabel);
            this.Controls.Add(this.DifficultyTextBox);
            this.Controls.Add(this.CourseDescriptionTextBox);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.CourseNameTextBox);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
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