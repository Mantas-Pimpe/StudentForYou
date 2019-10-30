using System;
using System.Windows.Forms;
using StudentForYouProfile;

namespace StudentForYou
{
    class UsernameChangeWindow : Form
    {
        private TextBox textBox1;
        private Label label1;
        private RoundedButton SaveButton;
        private string username;
        private Label label2;
        public string newUsername { get; set; }
        private ChangeUsername usernameChange = new ChangeUsername();
        public UsernameChangeWindow(string username)
        {
            InitializeComponent();
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
            this.textBox1.Size = new System.Drawing.Size(242, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 46);
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
            this.label2.Size = new System.Drawing.Size(295, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username is avaliable";
            this.label2.Visible = false;
            // 
            // UsernameChangeWindow
            // 
            this.AcceptButton = this.SaveButton;
            this.ClientSize = new System.Drawing.Size(292, 126);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "UsernameChangeWindow";
            this.Text = "StudentForYou";
            this.Load += new System.EventHandler(this.UsernameChangeWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void ChangeInfomationLabel()
        {

            switch (usernameChange.IsUsernameTaken(textBox1.Text))
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

            if (usernameChange.IsUsernameTaken(textBox1.Text) == 0)
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
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            ChangeInfomationLabel();
        }
    }
}
