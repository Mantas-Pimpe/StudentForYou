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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Difficulty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Downloads = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.coursesbtn = new System.Windows.Forms.Button();
            this.recentquestionsbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(894, 566);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Subject";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Course,
            this.Description,
            this.Difficulty,
            this.Downloads});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(37, 32);
            this.listView1.Margin = new System.Windows.Forms.Padding(8);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1165, 480);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Course
            // 
            this.Course.Text = "Course";
            this.Course.Width = 88;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 315;
            // 
            // Difficulty
            // 
            this.Difficulty.Text = "Difficulty";
            this.Difficulty.Width = 124;
            // 
            // Downloads
            // 
            this.Downloads.Text = "Downloads";
            this.Downloads.Width = 96;
            // 
            // coursesbtn
            // 
            this.coursesbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursesbtn.Location = new System.Drawing.Point(37, 627);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(200, 73);
            this.coursesbtn.TabIndex = 4;
            this.coursesbtn.Text = "Courses";
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.Click += new System.EventHandler(this.Coursesbtn_Click);
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
            // form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.recentquestionsbtn);
            this.Controls.Add(this.coursesbtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "form1";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Course;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader Difficulty;
        private System.Windows.Forms.ColumnHeader Downloads;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
    }
}