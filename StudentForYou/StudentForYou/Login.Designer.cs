namespace StudentForYou
{
    partial class Login
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
            this.UserProfile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserProfile
            // 
            this.UserProfile.Location = new System.Drawing.Point(914, 587);
            this.UserProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.UserProfile.Name = "UserProfile";
            this.UserProfile.Size = new System.Drawing.Size(264, 55);
            this.UserProfile.TabIndex = 1;
            this.UserProfile.Text = "TestUserProfile";
            this.UserProfile.UseVisualStyleBackColor = true;
            this.UserProfile.Click += new System.EventHandler(this.UserProfile_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.UserProfile);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserProfile;
    }
}

