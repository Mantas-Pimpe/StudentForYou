﻿namespace StudentForYou

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
            this.Chat = new System.Windows.Forms.Button();
            this.GroupChat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newpostbtn
            // 
            this.newpostbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newpostbtn.Location = new System.Drawing.Point(515, 567);
            this.newpostbtn.Margin = new System.Windows.Forms.Padding(6);
            this.newpostbtn.Name = "newpostbtn";
            this.newpostbtn.Size = new System.Drawing.Size(250, 55);
            this.newpostbtn.TabIndex = 0;
            this.newpostbtn.Text = "Create new post";
            this.newpostbtn.UseVisualStyleBackColor = true;
            this.newpostbtn.Click += new System.EventHandler(this.newpostbtn_Click);
            // 
            // coursesbtn
            // 
            this.coursesbtn.Location = new System.Drawing.Point(-117, 688);
            this.coursesbtn.Margin = new System.Windows.Forms.Padding(6);
            this.coursesbtn.Name = "coursesbtn";
            this.coursesbtn.Size = new System.Drawing.Size(0, 0);
            this.coursesbtn.TabIndex = 1;
            this.coursesbtn.Text = "Courses";
            this.coursesbtn.UseVisualStyleBackColor = true;
            this.coursesbtn.Click += new System.EventHandler(this.coursesbtn_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentquestionsbtn.Location = new System.Drawing.Point(515, 646);
            this.recentquestionsbtn.Margin = new System.Windows.Forms.Padding(6);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(250, 55);
            this.recentquestionsbtn.TabIndex = 2;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(963, 646);
            this.profilebtn.Margin = new System.Windows.Forms.Padding(6);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(270, 55);
            this.profilebtn.TabIndex = 3;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.Location = new System.Drawing.Point(15, 646);
            this.coursebtn.Margin = new System.Windows.Forms.Padding(6);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(270, 51);
            this.coursebtn.TabIndex = 4;
            this.coursebtn.Text = "Courses";
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new System.EventHandler(this.coursebtn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(40, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1169, 466);
            this.flowLayoutPanel1.TabIndex = 5;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Chat
            // 
            this.Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chat.Location = new System.Drawing.Point(963, 567);
            this.Chat.Margin = new System.Windows.Forms.Padding(6);
            this.Chat.Name = "Chat";
            this.Chat.Size = new System.Drawing.Size(270, 55);
            this.Chat.TabIndex = 5;
            this.Chat.Text = "Chat";
            this.Chat.UseVisualStyleBackColor = true;
            this.Chat.Click += new System.EventHandler(this.Chat_Click);
            // 
            // GroupChat
            // 
            this.GroupChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupChat.Location = new System.Drawing.Point(15, 567);
            this.GroupChat.Margin = new System.Windows.Forms.Padding(6);
            this.GroupChat.Name = "GroupChat";
            this.GroupChat.Size = new System.Drawing.Size(270, 55);
            this.GroupChat.TabIndex = 6;
            this.GroupChat.Text = "Group Chat";
            this.GroupChat.UseVisualStyleBackColor = true;
            this.GroupChat.Click += new System.EventHandler(this.GroupChat_Click);
            // 
            // RecentPostsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.GroupChat);
            this.Controls.Add(this.Chat);
            this.Controls.Add(this.coursebtn);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.recentquestionsbtn);
            this.Controls.Add(this.coursesbtn);
            this.Controls.Add(this.newpostbtn);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "RecentPostsForm";
            this.Text = "Recent questions";
            this.Load += new System.EventHandler(this.RecentPostsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newpostbtn;
        private System.Windows.Forms.Button coursesbtn;
        private System.Windows.Forms.Button recentquestionsbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button coursebtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Chat;
        private System.Windows.Forms.Button GroupChat;
    }
}