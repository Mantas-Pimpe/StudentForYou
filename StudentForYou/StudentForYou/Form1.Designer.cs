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
            this.SuspendLayout();
            // 
            // newpostbtn
            // 
            this.newpostbtn.Location = new System.Drawing.Point(468, 644);
            this.newpostbtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.newpostbtn.Name = "newpostbtn";
            this.newpostbtn.Size = new System.Drawing.Size(306, 36);
            this.newpostbtn.TabIndex = 0;
            this.newpostbtn.Text = "Create new post";
            this.newpostbtn.UseVisualStyleBackColor = true;
            this.newpostbtn.Click += new System.EventHandler(this.newpostbtn_Click);
            // 
            // RecentPostsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.newpostbtn);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "RecentPostsForm";
            this.Text = "Recent posts";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newpostbtn;
    }
}