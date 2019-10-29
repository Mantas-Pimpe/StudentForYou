using System;
using System.Windows.Forms;

namespace StudentForYou
{

    public partial class vuLoginForm : Form
    {
        private string username = string.Empty;
        private bool isOK = false;
        public vuLoginForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (loginCheck(textBox1.Text, textBox2.Text) == true)
            {
                username = textBox1.Text;
                isOK = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found in database", "UserError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal bool getLoginStatus()
        {
            return isOK;
        }

        public string getLoginUsername()
        {
            return username;
        }

        private bool loginCheck(string username, string password)
        {
            var filePath = @"Resources\TempDatabase.txt";
            string line;
            var file = new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(username))
                {
                    
                    var words = line.Split(' ');
                    if (username == words[0] && password == words[1])
                    {
                        file.Close();
                        return true;
                    }
                    words = null;
                }
            }
            file.Close();
            return false;
        }
    }
}
