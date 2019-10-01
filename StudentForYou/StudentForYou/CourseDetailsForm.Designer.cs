namespace StudentForYou
{
    partial class courseDetailsForm
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
            this.CourseDescriptionDetailsBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CourseNameDetailsBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CourseDescriptionDetailsBox
            // 
            this.CourseDescriptionDetailsBox.Location = new System.Drawing.Point(12, 68);
            this.CourseDescriptionDetailsBox.Multiline = true;
            this.CourseDescriptionDetailsBox.Name = "CourseDescriptionDetailsBox";
            this.CourseDescriptionDetailsBox.Size = new System.Drawing.Size(776, 337);
            this.CourseDescriptionDetailsBox.TabIndex = 0;
            this.CourseDescriptionDetailsBox.TextChanged += new System.EventHandler(this.CourseDescriptionDetailsBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(429, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CourseNameDetailsBox
            // 
            this.CourseNameDetailsBox.Location = new System.Drawing.Point(89, 12);
            this.CourseNameDetailsBox.Name = "CourseNameDetailsBox";
            this.CourseNameDetailsBox.ReadOnly = true;
            this.CourseNameDetailsBox.Size = new System.Drawing.Size(620, 22);
            this.CourseNameDetailsBox.TabIndex = 3;
            this.CourseNameDetailsBox.TextChanged += new System.EventHandler(this.CourseNameDetailsBox_TextChanged);
            // 
            // courseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CourseNameDetailsBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CourseDescriptionDetailsBox);
            this.Name = "courseDetailsForm";
            this.Text = "Course Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CourseDescriptionDetailsBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox CourseNameDetailsBox;
    }
}