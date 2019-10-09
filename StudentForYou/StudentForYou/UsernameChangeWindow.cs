using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    class UsernameChangeWindow: Form
    {
        private TextBox textBox1;
        private Label label1;
        private RoundedButton SaveButton;
        private int maximumUsernameLength = 15;
        private int minimumUsernameLength = 3;
        private string filePath;
        private string username;
        private Label label2;
        private string newUsername;
        public UsernameChangeWindow(string filePath, string username)
        {
            InitializeComponent();
            this.filePath = filePath;
            this.username = username;
            newUsername = username;

        }
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveButton = new StudentForYou.RoundedButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER NEW USERNAME";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(161, 70);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 44);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username is avaliable";
            this.label2.Visible = false;
            // 
            // UsernameChangeWindow
            // 
            this.ClientSize = new System.Drawing.Size(267, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "UsernameChangeWindow";
            this.Load += new System.EventHandler(this.UsernameChangeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private int IsUsernameTaken(string username)
        {
            // return 0 if everything checks out
            // return 1 if username is taken
            // return 2 if username is too long
            // return 3 if username is too short
            // return 4 if username contains spaces
            if (username.Length > maximumUsernameLength)
            {
                return 2;
            }
            else if (username.Length < minimumUsernameLength)
            {
                return 3;
            }
            else if (username.Contains(' ') == true)
            {
                return 4;
            }
            string[] lines = File.ReadLines(filePath).ToArray();
            string[] words = null;
            for (int i = 0; i < lines.Length; i++)
            {
                words = lines[i].Split(' ');
                if (words[0] == textBox1.Text)
                {
                    return 1;
                }
                words = null;
            }
            return 0;

        }
        private void ChangeInfomationLabel()
        {

            switch (IsUsernameTaken(textBox1.Text))
            {

                case 0:
                    label2.Text = "Username is avaliable";
                    label2.ForeColor = System.Drawing.Color.Green;
                    break;
                case 1:
                    label2.Text = "Username is already taken";
                    label2.ForeColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    label2.Text = "Username is too long";
                    label2.ForeColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    label2.Text = "Username is too short";
                    label2.ForeColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    label2.Text = "Username contains spaces";
                    label2.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    label2.Visible = false;
                    break;

            }
            label2.Visible = true;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //
            // Check if the username is avaliable
            // Change it with the old one
            // close this from
            //
            if (IsUsernameTaken(username) == 0)
            {
                this.newUsername = textBox1.Text;
                this.Close();
            }
            else
                MessageBox.Show("Please enter a valid username",
                    "Username unavaliable",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void UsernameChangeWindow_Load(object sender, EventArgs e)
        {

        }
        public string getUsername()
        {
            return newUsername;
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeInfomationLabel();
        }
    }
}
