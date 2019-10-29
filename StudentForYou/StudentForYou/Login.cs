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
            if (vuLogin.isOK)
            {
                var rpf = new RecentQuestions(vuLogin.username);
                rpf.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Please complete your login", "Bad Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
