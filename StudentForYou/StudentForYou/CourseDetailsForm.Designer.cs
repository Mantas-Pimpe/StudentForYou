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
            this.CourseDetailsBackButton = new System.Windows.Forms.Button();
            this.CourseDetailsSaveButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CourseDetailsBackButton
            // 
            this.CourseDetailsBackButton.Location = new System.Drawing.Point(834, 617);
            this.CourseDetailsBackButton.Name = "CourseDetailsBackButton";
            this.CourseDetailsBackButton.Size = new System.Drawing.Size(332, 64);
            this.CourseDetailsBackButton.TabIndex = 1;
            this.CourseDetailsBackButton.Text = "Back";
            this.CourseDetailsBackButton.UseVisualStyleBackColor = true;
            // 
            // CourseDetailsSaveButton
            // 
            this.CourseDetailsSaveButton.Location = new System.Drawing.Point(42, 617);
            this.CourseDetailsSaveButton.Name = "CourseDetailsSaveButton";
            this.CourseDetailsSaveButton.Size = new System.Drawing.Size(332, 64);
            this.CourseDetailsSaveButton.TabIndex = 2;
            this.CourseDetailsSaveButton.Text = "Save";
            this.CourseDetailsSaveButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1124, 554);
            this.textBox1.TabIndex = 3;
            // 
            // CourseDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CourseDetailsSaveButton);
            this.Controls.Add(this.CourseDetailsBackButton);
            this.Name = "CourseDetailsForm";
            this.Text = "Course Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CourseDetailsBackButton;
        private System.Windows.Forms.Button CourseDetailsSaveButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}