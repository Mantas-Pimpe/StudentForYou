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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.roundPicturebox1 = new StudentForYou.RoundPicturebox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.CourseNameTextBox = new System.Windows.Forms.Label();
            this.CourseDescriptionTextBox = new System.Windows.Forms.Label();
            this.DifficultyTextBox = new System.Windows.Forms.Label();
            this.SaveSubjectButton = new StudentForYou.RoundedButton();
            this.CancelAddSubjectButton = new StudentForYou.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(989, 20);
            this.textBox1.TabIndex = 0;
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Location = new System.Drawing.Point(336, 112);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(100, 50);
            this.roundPicturebox1.TabIndex = 1;
            this.roundPicturebox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(213, 125);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(989, 309);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(213, 480);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 20);
            this.textBox3.TabIndex = 3;
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.AutoSize = true;
            this.CourseNameTextBox.Location = new System.Drawing.Point(81, 86);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(71, 13);
            this.CourseNameTextBox.TabIndex = 4;
            this.CourseNameTextBox.Text = "Course Name";
            // 
            // CourseDescriptionTextBox
            // 
            this.CourseDescriptionTextBox.AutoSize = true;
            this.CourseDescriptionTextBox.Location = new System.Drawing.Point(81, 128);
            this.CourseDescriptionTextBox.Name = "CourseDescriptionTextBox";
            this.CourseDescriptionTextBox.Size = new System.Drawing.Size(96, 13);
            this.CourseDescriptionTextBox.TabIndex = 5;
            this.CourseDescriptionTextBox.Text = "Course Description";
            this.CourseDescriptionTextBox.Click += new System.EventHandler(this.CourseDescriptionTextBox_Click);
            // 
            // DifficultyTextBox
            // 
            this.DifficultyTextBox.AutoSize = true;
            this.DifficultyTextBox.Location = new System.Drawing.Point(91, 483);
            this.DifficultyTextBox.Name = "DifficultyTextBox";
            this.DifficultyTextBox.Size = new System.Drawing.Size(47, 13);
            this.DifficultyTextBox.TabIndex = 6;
            this.DifficultyTextBox.Text = "Difficulty";
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
            this.Controls.Add(this.DifficultyTextBox);
            this.Controls.Add(this.CourseDescriptionTextBox);
            this.Controls.Add(this.CourseNameTextBox);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private RoundPicturebox roundPicturebox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label CourseNameTextBox;
        private System.Windows.Forms.Label CourseDescriptionTextBox;
        private System.Windows.Forms.Label DifficultyTextBox;
        private RoundedButton SaveSubjectButton;
        private RoundedButton CancelAddSubjectButton;
    }
}