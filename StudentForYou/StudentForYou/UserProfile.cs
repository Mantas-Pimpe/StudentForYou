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
        private RoundedButton backToPreviousForm;
        private Label label1;
        private Form previousForm = null;

        public UserProfile(String username, Login loginform)
        {
            InitializeComponent();
            this.label1.Text = this.label1.Text + username;
            this.UserName.Text = username;
            setPreviousForm(loginform, ref previousForm);
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
            // save
            // Close and reopen app
            // 
            // 
            Application.Restart();
        }
        private void setPreviousForm(Login loginform, ref Form previousForm)
        {
            previousForm = loginform;
        }

        private void BackToPreviousForm_Click(object sender, EventArgs e)
        {
            this.Close();
            previousForm.Show();
        }
        private void UserProfile_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            //
            // save current data
            //
            Application.Exit();
        }
        private int SaveData()
        {

            return 0;
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.UserInfo = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backToPreviousForm = new StudentForYou.RoundedButton();
            this.usernameChange = new StudentForYou.RoundedButton();
            this.loggingOut = new StudentForYou.RoundedButton();
            this.roundPicturebox1 = new StudentForYou.RoundPicturebox();
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
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "About ";
            // 
            // backToPreviousForm
            // 
            this.backToPreviousForm.Location = new System.Drawing.Point(2, 2);
            this.backToPreviousForm.Name = "backToPreviousForm";
            this.backToPreviousForm.Size = new System.Drawing.Size(71, 41);
            this.backToPreviousForm.TabIndex = 9;
            this.backToPreviousForm.Text = "Back";
            this.backToPreviousForm.UseVisualStyleBackColor = true;
            this.backToPreviousForm.Click += new System.EventHandler(this.BackToPreviousForm_Click);
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
            // UserProfile
            // 
            this.ClientSize = new System.Drawing.Size(284, 480);
            this.Controls.Add(this.backToPreviousForm);
            this.Controls.Add(this.usernameChange);
            this.Controls.Add(this.loggingOut);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserInfo);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "UserProfile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserProfile_FormClosing_1);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}