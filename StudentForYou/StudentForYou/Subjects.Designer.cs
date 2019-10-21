namespace StudentForYou
{
    partial class form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.recentquestionsbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.SubjectsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 627);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 68);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentquestionsbtn.Location = new System.Drawing.Point(514, 627);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(200, 73);
            this.recentquestionsbtn.TabIndex = 5;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            this.recentquestionsbtn.Click += new System.EventHandler(this.recentquestionsbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(1002, 627);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(200, 73);
            this.profilebtn.TabIndex = 6;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // SubjectsLayoutPanel
            // 
            this.SubjectsLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.SubjectsLayoutPanel.Name = "SubjectsLayoutPanel";
            this.SubjectsLayoutPanel.Size = new System.Drawing.Size(1190, 532);
            this.SubjectsLayoutPanel.TabIndex = 8;
            this.SubjectsLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SubjectsLayoutPanel_Paint);
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.SubjectsLayoutPanel);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.recentquestionsbtn);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "form1";
            this.Text = "Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.FlowLayoutPanel SubjectsLayoutPanel;
    }
}