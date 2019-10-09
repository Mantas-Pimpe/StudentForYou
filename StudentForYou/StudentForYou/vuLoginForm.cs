using System;
using System.Windows.Forms;

namespace StudentForYou
{

    public partial class vuLoginForm : Form
    {
        private string username = String.Empty;
        public vuLoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (loginCheck(textBox1.Text, textBox2.Text) == true)
            {
                username = textBox1.Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found in database", "UserError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string getLoginUsername()
        {
            return username;
        }

        private bool loginCheck(string username, string password)
        {
            string filePath = @"Resources\TempDatabase.txt";
            string line;
            string[] words = null;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                words = null;
                if (line.Contains(username))
                {
                    words = line.Split(' ');
                    if (username == words[0] && password == words[1])
                    {
                        file.Close();
                        return true;
                    }
                }
            }
            file.Close();
            return false;
        }
    }
}
