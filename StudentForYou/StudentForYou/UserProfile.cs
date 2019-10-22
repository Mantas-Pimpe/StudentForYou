using System;
using System.IO;
using System.Linq;
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
        private RoundedButton subjectsbtn;
        private RoundedButton recentpostsbtn;
        private Label label1;
        private string newUsername;
        private int currentUserDataLine = 0;
        private string[] bioArray = new string[100];
        private string filePath = @"Resources\TempDatabase.txt";
        private RoundedButton PictureChangeButton;
        private string pictureFilePath = @"Resources\StockImage.png";

        public UserProfile(String username)
        {
            InitializeComponent();
            getUserData(username);

        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfile));
            this.UserInfo = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recentpostsbtn = new StudentForYou.RoundedButton();
            this.subjectsbtn = new StudentForYou.RoundedButton();
            this.usernameChange = new StudentForYou.RoundedButton();
            this.loggingOut = new StudentForYou.RoundedButton();
            this.roundPicturebox1 = new StudentForYou.RoundPicturebox();
            this.PictureChangeButton = new StudentForYou.RoundedButton();
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserInfo
            // 
            this.UserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UserInfo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UserInfo.Location = new System.Drawing.Point(496, 282);
            this.UserInfo.Multiline = true;
            this.UserInfo.Name = "UserInfo";
            this.UserInfo.Size = new System.Drawing.Size(316, 144);
            this.UserInfo.TabIndex = 1;
            this.UserInfo.TextChanged += new System.EventHandler(this.UserInfo_TextChanged);
            this.UserInfo.Leave += new System.EventHandler(this.UserInfo_Leave);
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(496, 188);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(316, 73);
            this.UserName.TabIndex = 4;
            this.UserName.Text = "USERNAME";
            this.UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "About ";
            // 
            // recentpostsbtn
            // 
            this.recentpostsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.recentpostsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recentpostsbtn.Location = new System.Drawing.Point(237, 502);
            this.recentpostsbtn.Name = "recentpostsbtn";
            this.recentpostsbtn.Size = new System.Drawing.Size(155, 174);
            this.recentpostsbtn.TabIndex = 10;
            this.recentpostsbtn.Text = "Recent posts";
            this.recentpostsbtn.UseVisualStyleBackColor = true;
            this.recentpostsbtn.Click += new System.EventHandler(this.RecentsPostsbtn_Click);
            // 
            // subjectsbtn
            // 
            this.subjectsbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.subjectsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectsbtn.Location = new System.Drawing.Point(35, 502);
            this.subjectsbtn.Name = "subjectsbtn";
            this.subjectsbtn.Size = new System.Drawing.Size(155, 174);
            this.subjectsbtn.TabIndex = 9;
            this.subjectsbtn.Text = "Subjects";
            this.subjectsbtn.UseVisualStyleBackColor = true;
            this.subjectsbtn.Click += new System.EventHandler(this.RoundedButton1_Click);
            // 
            // usernameChange
            // 
            this.usernameChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.usernameChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameChange.Location = new System.Drawing.Point(1056, 291);
            this.usernameChange.Name = "usernameChange";
            this.usernameChange.Size = new System.Drawing.Size(155, 174);
            this.usernameChange.TabIndex = 8;
            this.usernameChange.Text = "Change Username";
            this.usernameChange.UseVisualStyleBackColor = true;
            this.usernameChange.Click += new System.EventHandler(this.UsernameChange_Click);
            // 
            // loggingOut
            // 
            this.loggingOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loggingOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loggingOut.Location = new System.Drawing.Point(1056, 502);
            this.loggingOut.Name = "loggingOut";
            this.loggingOut.Size = new System.Drawing.Size(155, 174);
            this.loggingOut.TabIndex = 7;
            this.loggingOut.Text = "Log Out";
            this.loggingOut.UseVisualStyleBackColor = true;
            this.loggingOut.Click += new System.EventHandler(this.LoggingOut_Click);
            // 
            // roundPicturebox1
            // 
            this.roundPicturebox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.roundPicturebox1.Image = ((System.Drawing.Image)(resources.GetObject("roundPicturebox1.Image")));
            this.roundPicturebox1.Location = new System.Drawing.Point(569, 26);
            this.roundPicturebox1.Name = "roundPicturebox1";
            this.roundPicturebox1.Size = new System.Drawing.Size(173, 159);
            this.roundPicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roundPicturebox1.TabIndex = 6;
            this.roundPicturebox1.TabStop = false;
            // 
            // PictureChangeButton
            // 
            this.PictureChangeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.PictureChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PictureChangeButton.Location = new System.Drawing.Point(895, 291);
            this.PictureChangeButton.Name = "PictureChangeButton";
            this.PictureChangeButton.Size = new System.Drawing.Size(155, 174);
            this.PictureChangeButton.TabIndex = 11;
            this.PictureChangeButton.Text = "Change Picture";
            this.PictureChangeButton.UseVisualStyleBackColor = true;
            this.PictureChangeButton.Click += new System.EventHandler(this.PictureChangeButton_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1248, 712);
            this.Controls.Add(this.PictureChangeButton);
            this.Controls.Add(this.recentpostsbtn);
            this.Controls.Add(this.subjectsbtn);
            this.Controls.Add(this.usernameChange);
            this.Controls.Add(this.loggingOut);
            this.Controls.Add(this.roundPicturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.UserInfo);
            this.MaximumSize = new System.Drawing.Size(1920, 1200);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "UserProfile";
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserProfile_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.roundPicturebox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void getUserData(String username)
        {
            bool isNameFound = false;
            string line;
            string[] words = null;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                words = null;
                if (line.Contains(username))
                {
                    words = line.Split(' ');
                    if (username == words[0])
                    {
                        if(words[2] !="noPicture")
                            pictureFilePath = words[2];
                        for (int i = 3; i < words.Length; i++)
                        {
                            bioArray[i - 3] = words[i];
                        }
                        isNameFound = true;
                        break;
                    }
                }
                currentUserDataLine++;
            }
            file.Close();
            if (!isNameFound)
            {
                MessageBox.Show("Name not found in database", "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            string bio = "";
            int j = 0;
            while (!string.IsNullOrEmpty(bioArray[j]))
            {
                bio = bio + bioArray[j] + " ";
                j++;
            }
            label1.Text = label1.Text + username;
            UserName.Text = username;
            newUsername = username;
            UserInfo.Text = bio;
            roundPicturebox1.ImageLocation = pictureFilePath;
        }
        private void saveUserData(string currentUsername, string newUsername)
        {
            string lineToWrite = null;
            using (StreamReader reader = new StreamReader(filePath))
            {
                for (int i = 0; i <= currentUserDataLine; i++)
                    lineToWrite = reader.ReadLine();
            }
            string[] lineWords = lineToWrite.Split(' ');
            lineWords[0] = newUsername;
            lineWords[2] = pictureFilePath;
            lineToWrite = null;
            for (int i = 0; i < lineWords.Length; i++)
            {
                if (lineWords.Length - 1 == i)
                    lineToWrite = lineToWrite + lineWords[i];
                else
                    lineToWrite = lineToWrite + lineWords[i] + " ";
            }
            string[] lines = File.ReadAllLines(filePath);
            lines[currentUserDataLine] = lineToWrite;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                for (int currentLine = 0; currentLine < lines.Length; currentLine++)
                {
                    writer.WriteLine(lines[currentLine]);
                }
            }

        }

        private void UserInfo_Leave(object sender, EventArgs e)
        {
            //
            // Save textbox contents to file/ database
            //

        }

        private void UsernameChange_Click(object sender, EventArgs e)
        {
            UsernameChangeWindow UsernameChange = new UsernameChangeWindow(filePath, UserName.Text);
            UsernameChange.ShowDialog();
            newUsername = UsernameChange.getUsername();
            if(newUsername!= UserName.Text)
            {
                MessageBox.Show("Relog is required", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
                
        }

        private void LoggingOut_Click(object sender, EventArgs e)
        {
            //
            // Log out and promt to the login screen again, or just reopen the app
            // 
            saveUserData(UserName.Text, newUsername);
            Application.Restart();
        }

        private void RoundedButton1_Click(object sender, EventArgs e)
        {
            
            var subjects = new form1(UserName.Text);
            subjects.Show();
            this.Close();
        }

        private void RecentsPostsbtn_Click(object sender, EventArgs e)
        {
            
            var rpf = new RecentQuestions(UserName.Text);
            rpf.Show();
            this.Close();
        }
        private void UserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            saveUserData(UserName.Text, newUsername);
            if (Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }

        private void PictureChangeButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    pictureFilePath = openFileDialog.FileName;
                }
            }
        }

        private void UserInfo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}