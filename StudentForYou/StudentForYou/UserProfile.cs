using System;
using System.Linq;
using System.Windows.Forms;
using StudentForYouProfile;
using StudentForYou.DB;

namespace StudentForYou
{
    public class UserProfile : Form
    {
        private TextBox UserInfo;
        private Label UserName;
        private RoundPicturebox roundPicturebox1;
        private RoundedButton loggingOut;
        private RoundedButton usernameChange;
        private Label label1;
        private string newUsername;
        private RoundedButton PictureChangeButton;
        private Panel panel1;
        private Button coursebtn;
        private Button recentquestionsbtn;
        private Button profilebtn;
        //private string pictureFilePath = @"Resources\StockImage.png";
        public ProfileDB db = new ProfileDB();
        User userData;
        int id;
        public UserProfile(int id)
        {
            InitializeComponent();
            userData = db.GetUser(id);
            this.id = id;
            label1.Text = label1.Text + userData.username;
            UserName.Text = userData.username;
            UserInfo.Text = userData.bio;
            newUsername = userData.username;
            //roundPicturebox1.ImageLocation = userData.Item4;
            profilebtn.Enabled = false;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.UserInfo = new TextBox();
            this.UserName = new Label();
            this.label1 = new Label();
            this.panel1 = new Panel();
            this.coursebtn = new Button();
            this.recentquestionsbtn = new Button();
            this.profilebtn = new Button();
            this.PictureChangeButton = new RoundedButton();
            this.usernameChange = new RoundedButton();
            this.loggingOut = new RoundedButton();
            this.roundPicturebox1 = new RoundPicturebox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.UserInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UserInfo.Location = new System.Drawing.Point(410, 340);
            this.UserInfo.Multiline = true;
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(407, 217);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.Leave += new System.EventHandler(this.UserInfo_Leave);
            // 
            // UserName
            // 
            this.UserName.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(450, 237);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(316, 73);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "USERNAME";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 54);
            this.label1.TabIndex = 5;
            this.label1.Text = "About ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.coursebtn);
            this.panel1.Controls.Add(this.recentquestionsbtn);
            this.panel1.Controls.Add(this.profilebtn);
            this.panel1.Location = new System.Drawing.Point(-5, 592);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 122);
            this.panel1.TabIndex = 12;
            // 
            // coursebtn
            // 
            this.coursebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursebtn.Location = new System.Drawing.Point(16, 27);
            this.coursebtn.Margin = new Padding(6);
            this.coursebtn.Name = "coursebtn";
            this.coursebtn.Size = new System.Drawing.Size(270, 51);
            this.coursebtn.TabIndex = 4;
            this.coursebtn.Text = "Courses";
            this.coursebtn.UseVisualStyleBackColor = true;
            this.coursebtn.Click += new EventHandler(this.Coursebtn_Click);
            // 
            // recentquestionsbtn
            // 
            this.recentquestionsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentquestionsbtn.Location = new System.Drawing.Point(502, 25);
            this.recentquestionsbtn.Margin = new Padding(6);
            this.recentquestionsbtn.Name = "recentquestionsbtn";
            this.recentquestionsbtn.Size = new System.Drawing.Size(250, 55);
            this.recentquestionsbtn.TabIndex = 2;
            this.recentquestionsbtn.Text = "Recent questions";
            this.recentquestionsbtn.UseVisualStyleBackColor = true;
            this.recentquestionsbtn.Click += new EventHandler(this.Recentquestionsbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(964, 23);
            this.profilebtn.Margin = new Padding(6);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(270, 55);
            this.profilebtn.TabIndex = 3;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new EventHandler(this.Profilebtn_Click);
            // 
            // PictureChangeButton
            // 
            this.PictureChangeButton.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.PictureChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureChangeButton.Location = new System.Drawing.Point(866, 342);
            this.PictureChangeButton.Name = "PictureChangeButton";
            this.PictureChangeButton.Size = new System.Drawing.Size(370, 54);
            this.PictureChangeButton.TabIndex = 11;
            this.PictureChangeButton.Text = "Change Picture";
            this.PictureChangeButton.UseVisualStyleBackColor = true;
            this.PictureChangeButton.Click += new EventHandler(this.PictureChangeButton_Click);
            // 
            // usernameChange
            // 
            this.usernameChange.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.usernameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameChange.Location = new System.Drawing.Point(866, 422);
            this.usernameChange.Name = "usernameChange";
            this.usernameChange.Size = new System.Drawing.Size(370, 54);
            this.usernameChange.TabIndex = 8;
            this.usernameChange.Text = "Change Username";
            this.usernameChange.UseVisualStyleBackColor = true;
            this.usernameChange.Click += new EventHandler(this.UsernameChange_Click);
            // 
            // loggingOut
            // 
            this.loggingOut.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.loggingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggingOut.Location = new System.Drawing.Point(866, 503);
            this.loggingOut.Name = "loggingOut";
            this.loggingOut.Size = new System.Drawing.Size(370, 54);
            this.loggingOut.TabIndex = 7;
            this.loggingOut.Text = "Log Out";
            this.loggingOut.UseVisualStyleBackColor = true;
            this.loggingOut.Click += new EventHandler(this.LoggingOut_Click);
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Bottom)));
            this.roundPicturebox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPicturebox1.Image")));
            this.roundPicturebox1.Location = new System.Drawing.Point(498, 12);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(220, 222);
            this.roundPicturebox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.roundPicturebox1.TabIndex = 6;
            this.roundPicturebox1.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleMode = AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureChangeButton);
            this.Controls.Add(this.usernameChange);
            this.Controls.Add(this.loggingOut);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserInfo);
            this.MaximumSize = new System.Drawing.Size(1920, 1200);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "UserProfile";
            this.Text = "StudentForYou";
            this.FormClosed += new FormClosedEventHandler(this.UserProfile_FormClosed);
            this.Load += new EventHandler(this.UserProfile_Load);
            this.panel1.ResumeLayout(false);
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
            var UsernameChange = new UsernameChangeWindow(UserName.Text);
            UsernameChange.ShowDialog();
            newUsername = UsernameChange.newUsername;
            if (newUsername != UserName.Text)
            {
                MessageBox.Show("Relog is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

        }

        private void LoggingOut_Click(object sender, EventArgs e)
        {
            db.UpdateUser(new User(userData.id, newUsername, UserInfo.Text, userData.creationDate));
            Application.Restart();
        }
        private void UserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.UpdateUser(new User(userData.id, newUsername, UserInfo.Text, userData.creationDate));
            if (Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }

        private void PictureChangeButton_Click(object sender, EventArgs e)
        {
            /*var newPictureFilePath = profileLogic.PictureChange();
            if (newPictureFilePath.Equals("noPicture"))
                roundPicturebox1.ImageLocation = pictureFilePath;
            else
            {
                pictureFilePath = newPictureFilePath;
                roundPicturebox1.ImageLocation = pictureFilePath;
                
            }*/
                
        }

        private void Coursebtn_Click(object sender, EventArgs e)
        {
            var subjects = new form1(id);
            subjects.Show();
            this.Close();
        }

        private void Recentquestionsbtn_Click(object sender, EventArgs e)
        {
            var rpf = new RecentQuestions(id);
            rpf.Show();
            this.Close();
        }

        private void Profilebtn_Click(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }
    }
}