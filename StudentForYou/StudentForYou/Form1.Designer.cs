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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.newpostbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpostbtn
            // 
            this.newpostbtn.Location = new System.Drawing.Point(313, 408);
            this.newpostbtn.Name = "newpostbtn";
            this.newpostbtn.Size = new System.Drawing.Size(169, 30);
            this.newpostbtn.TabIndex = 0;
            this.newpostbtn.Text = "Create new post";
            this.newpostbtn.UseVisualStyleBackColor = true;
            this.newpostbtn.Click += new System.EventHandler(this.newpostbtn_Click);
            // 
            // RecentPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.newpostbtn);
            this.Name = "RecentPostsForm";
            this.Text = "Recent posts";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button newpostbtn;
    }
}