using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public class UserProfile : Form
    {
        private TextBox UserInfo;
        private Label UserName;
        private RoundPicturebox roundPicturebox1;
        private RoundedButton loggingOut;
        private RoundedButton usernameChange;
        private RoundedButton roundedButton1;
        private RoundedButton RecentsPostsbtn;
        private Label label1;

        public UserProfile(String username)
        {
            InitializeComponent();
            this.label1.Text = this.label1.Text + username;
            this.UserName.Text = username; 
        }

        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.UserInfo = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameChange = new StudentForYou.RoundedButton();
            this.loggingOut = new StudentForYou.RoundedButton();
            this.roundPicturebox1 = new StudentForYou.RoundPicturebox();
            this.roundedButton1 = new StudentForYou.RoundedButton();
            this.RecentsPostsbtn = new StudentForYou.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UserInfo.Location = new System.Drawing.Point(12, 204);
            this.UserInfo.Multiline = true;
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(260, 34);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Leave += new System.EventHandler(this.UserInfo_Leave);
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.UserName.Location = new System.Drawing.Point(77, 139);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(137, 35);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "USERNAME";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "About ";
            // 
            // usernameChange
            // 
            this.usernameChange.Location = new System.Drawing.Point(12, 244);
            this.usernameChange.Name = "usernameChange";
            this.usernameChange.Size = new System.Drawing.Size(138, 43);
            this.usernameChange.TabIndex = 8;
            this.usernameChange.Text = "Change Username";
            this.usernameChange.UseVisualStyleBackColor = true;
            this.usernameChange.Click += new System.EventHandler(this.UsernameChange_Click);
            // 
            // loggingOut
            // 
            this.loggingOut.Location = new System.Drawing.Point(12, 425);
            this.loggingOut.Name = "loggingOut";
            this.loggingOut.Size = new System.Drawing.Size(138, 43);
            this.loggingOut.TabIndex = 7;
            this.loggingOut.Text = "Log Out";
            this.loggingOut.UseVisualStyleBackColor = true;
            this.loggingOut.Click += new System.EventHandler(this.LoggingOut_Click);
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPicturebox1.Image")));
            this.roundPicturebox1.Location = new System.Drawing.Point(79, 12);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(135, 124);
            this.roundPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicturebox1.TabIndex = 6;
            this.roundPicturebox1.TabStop = false;
            // 
            // roundedButton1
            // 
            this.roundedButton1.Location = new System.Drawing.Point(12, 293);
            this.roundedButton1.Name = "roundedButton1";
            this.roundedButton1.Size = new System.Drawing.Size(138, 42);
            this.roundedButton1.TabIndex = 9;
            this.roundedButton1.Text = "Subjects";
            this.roundedButton1.UseVisualStyleBackColor = true;
            this.roundedButton1.Click += new System.EventHandler(this.RoundedButton1_Click);
            // 
            // RecentsPostsbtn
            // 
            this.RecentsPostsbtn.Location = new System.Drawing.Point(12, 341);
            this.RecentsPostsbtn.Name = "RecentsPostsbtn";
            this.RecentsPostsbtn.Size = new System.Drawing.Size(138, 42);
            this.RecentsPostsbtn.TabIndex = 10;
            this.RecentsPostsbtn.Text = "Recent posts";
            this.RecentsPostsbtn.UseVisualStyleBackColor = true;
            this.RecentsPostsbtn.Click += new System.EventHandler(this.RecentsPostsbtn_Click);
            // 
            // UserProfile
            // 
            this.ClientSize = new System.Drawing.Size(284, 480);
            this.Controls.Add(this.RecentsPostsbtn);
            this.Controls.Add(this.roundedButton1);
            this.Controls.Add(this.usernameChange);
            this.Controls.Add(this.loggingOut);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserInfo);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "UserProfile";
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserInfo_Leave(object sender, EventArgs e)
        {
            //
            // Save textbox contents to file/ database
            //
        }

        private void UsernameChange_Click(object sender, EventArgs e)
        {
            UsernameChangeWindow UsernameChange = new UsernameChangeWindow();
            UsernameChange.ShowDialog();
        }

        private void LoggingOut_Click(object sender, EventArgs e)
        {
            //
            // Log out and promt to the login screen again, or just reopen the app
            // 
        }

        private void RoundedButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            form1 subjects = new form1();
            subjects.ShowDialog();
            this.Show();
            
            
        }

        private void RecentsPostsbtn_Click(object sender, EventArgs e)
        {
            RecentPostsForm rpf = new RecentPostsForm();
            rpf.Show();
        }
    }
}