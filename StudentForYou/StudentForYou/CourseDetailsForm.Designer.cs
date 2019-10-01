namespace StudentForYou
{
    partial class CourseDetailsForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CourseDetailsSaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CourseNameTextBox
            // 
            this.CourseNameTextBox.Location = new System.Drawing.Point(88, 23);
            this.CourseNameTextBox.Name = "CourseNameTextBox";
            this.CourseNameTextBox.Size = new System.Drawing.Size(585, 22);
            this.CourseNameTextBox.TabIndex = 0;
            this.CourseNameTextBox.TextChanged += new System.EventHandler(this.CourseNameTextBox_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 66);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(761, 372);
            this.textBox1.TabIndex = 1;
            // 
            // CourseDetailsSaveButton
            // 
            this.CourseDetailsSaveButton.Location = new System.Drawing.Point(88, 468);
            this.CourseDetailsSaveButton.Name = "CourseDetailsSaveButton";
            this.CourseDetailsSaveButton.Size = new System.Drawing.Size(287, 23);
            this.CourseDetailsSaveButton.TabIndex = 2;
            this.CourseDetailsSaveButton.Text = "Save";
            this.CourseDetailsSaveButton.UseVisualStyleBackColor = true;
            this.CourseDetailsSaveButton.Click += new System.EventHandler(this.CourseDetailsSaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CourseDetailsSaveButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CourseNameTextBox);
            this.Name = "CourseDetailsForm";
            this.Text = "Course Details";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CourseDetailsSaveButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox CourseNameTextBox;
    }
}