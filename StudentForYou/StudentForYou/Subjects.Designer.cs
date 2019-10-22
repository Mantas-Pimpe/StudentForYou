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
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.SubjectsLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.coursebtn = new System.Windows.Forms.Button();
            this.recentquestionsbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubjectsLayoutPanel
            // 
            this.SubjectsLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.SubjectsLayoutPanel.Name = "SubjectsLayoutPanel";
            this.SubjectsLayoutPanel.Size = new System.Drawing.Size(1190, 532);
            this.SubjectsLayoutPanel.TabIndex = 8;
            this.SubjectsLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SubjectsLayoutPanel_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.coursebtn);
            this.panel1.Controls.Add(this.recentquestionsbtn);
            this.panel1.Controls.Add(this.profilebtn);
            this.panel1.Location = new System.Drawing.Point(-6, 593);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 122);
            this.panel1.TabIndex = 13;
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.Location = new System.Drawing.Point(16, 27);
            this.coursebtn.Margin = new System.Windows.Forms.Padding(6);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(270, 51);
            this.coursebtn.TabIndex = 4;
            this.coursebtn.Text = "Courses";
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.Coursebtn_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentquestionsbtn.Location = new System.Drawing.Point(502, 25);
            this.recentquestionsbtn.Margin = new System.Windows.Forms.Padding(6);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(250, 55);
            this.recentquestionsbtn.TabIndex = 2;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            this.recentquestionsbtn.Click += new System.EventHandler(this.Recentquestionsbtn_Click_1);
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(964, 23);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(6);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(270, 55);
            this.profilebtn.TabIndex = 3;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.Profilebtn_Click_1);
            // 
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SubjectsLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "form1";
            this.Text = "Courses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.FlowLayoutPanel SubjectsLayoutPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
    }
}