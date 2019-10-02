namespace StudentForYou
{
    partial class RecentPostsForm
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
            this.newpostbtn = new System.Windows.Forms.Button();
            this.coursesbtn = new System.Windows.Forms.Button();
            this.recentquestionsbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpostbtn
            // 
            this.newpostbtn.Location = new System.Drawing.Point(302, 357);
            this.newpostbtn.Name = "newpostbtn";
            this.newpostbtn.Size = new System.Drawing.Size(169, 30);
            this.newpostbtn.TabIndex = 0;
            this.newpostbtn.Text = "Create new post";
            this.newpostbtn.UseVisualStyleBackColor = true;
            this.newpostbtn.Click += new System.EventHandler(this.newpostbtn_Click);
            // 
            // coursesbtn
            // 
            this.coursesbtn.Location = new System.Drawing.Point(79, 13);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(75, 30);
            this.coursesbtn.TabIndex = 1;
            this.coursesbtn.Text = "Courses";
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.Click += new System.EventHandler(this.coursesbtn_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Location = new System.Drawing.Point(336, 13);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(144, 30);
            this.recentquestionsbtn.TabIndex = 2;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            // 
            // profilebtn
            // 
            this.profilebtn.Location = new System.Drawing.Point(630, 13);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(75, 30);
            this.profilebtn.TabIndex = 3;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            // 
            // RecentPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.recentquestionsbtn);
            this.Controls.Add(this.coursesbtn);
            this.Controls.Add(this.newpostbtn);
            this.Name = "RecentPostsForm";
            this.Text = "Recent posts";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newpostbtn;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
    }
}