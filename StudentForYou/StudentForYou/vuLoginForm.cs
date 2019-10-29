using System;
using System.Windows.Forms;
using StudentForYouProfile;

namespace StudentForYou
{

    public partial class vuLoginForm : Form
    {
        public string username { get; set; }
        public bool isOK { get; set; }
        UserLogin newLogin = new UserLogin();
        public vuLoginForm()
        {
            InitializeComponent();
            isOK = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (newLogin.loginCheck(textBox1.Text, textBox2.Text) == true)
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

    }
}
