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
            this.coursebtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // newpostbtn
            // 
            this.newpostbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpostbtn.Location = new System.Drawing.Point(520, 534);
            this.newpostbtn.Name = "newpostbtn";
            this.newpostbtn.Size = new System.Drawing.Size(200, 73);
            this.newpostbtn.TabIndex = 0;
            this.newpostbtn.Text = "Create new post";
            this.newpostbtn.UseVisualStyleBackColor = true;
            this.newpostbtn.Click += new System.EventHandler(this.newpostbtn_Click);
            // 
            // coursesbtn
            // 
            this.coursesbtn.Location = new System.Drawing.Point(40, 647);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(0, 0);
            this.coursesbtn.TabIndex = 1;
            this.coursesbtn.Text = "Courses";
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.Click += new System.EventHandler(this.coursesbtn_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentquestionsbtn.Location = new System.Drawing.Point(520, 627);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(200, 73);
            this.recentquestionsbtn.TabIndex = 2;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(1009, 627);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(200, 73);
            this.profilebtn.TabIndex = 3;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.Location = new System.Drawing.Point(31, 627);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(200, 73);
            this.coursebtn.TabIndex = 4;
            this.coursebtn.Text = "Courses";
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 466);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // RecentPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.coursebtn);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.recentquestionsbtn);
            this.Controls.Add(this.coursesbtn);
            this.Controls.Add(this.newpostbtn);
            this.Name = "RecentPostsForm";
            this.Text = "Recent questions";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newpostbtn;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}