using System;
using System.Windows.Forms;
using StudentForYou.DB;

namespace StudentForYou
{

    public partial class vuLoginForm : Form
    {
        public string username { get; set; }
        public int id { get; set; }
        public bool isOK { get; set; }

        ProfileDB db = new ProfileDB();
        public vuLoginForm()
        {
            InitializeComponent();
            isOK = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (db.GetUserLoginID(textBox1.Text, textBox2.Text) != null) 
            {
                username = textBox1.Text;
                id = db.GetUserLoginID(textBox1.Text, textBox2.Text) ?? default(int); 
                isOK = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("User not found in database", "UserError", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var newAccount = new CreateAccountForm();
            newAccount.ShowDialog();

        }


    }
}
