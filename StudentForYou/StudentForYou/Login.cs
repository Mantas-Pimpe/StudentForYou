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
        private string username = string.Empty;
        public Login()
        {
            InitializeComponent();
        }


        private void googlebtn_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var vuLogin  = new vuLoginForm();
            vuLogin.ShowDialog();
            username = vuLogin.getLoginUsername();
            var rpf = new RecentQuestions(username);
            rpf.Show();
            this.Hide();
        }
    }
}
