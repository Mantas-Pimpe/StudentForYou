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
    public partial class Login : Form
    {
        private string username = String.Empty;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void UserProfile_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username))
                MessageBox.Show("Login is required", "No Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                UserProfile Profile = new UserProfile(username,this);
                this.Hide();
                Profile.Show();
            }


        }

        private void Button2_Click(object sender, EventArgs e)
        {
            vuLoginForm vuLogin = new vuLoginForm();
            vuLogin.ShowDialog();
            username = vuLogin.getLoginUsername();
        }
    }
}
