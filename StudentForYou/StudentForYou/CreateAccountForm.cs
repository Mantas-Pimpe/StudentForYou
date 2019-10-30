using System;
using System.Windows.Forms;
using StudentForYouProfile;

namespace StudentForYou
{
    public partial class CreateAccountForm : Form
    {
        private readonly ChangeUsername changeUsername = new ChangeUsername();

        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            switch (changeUsername.IsUsernameTaken(UsernameTextBox.Text))
            {

                case 0:
                    label4.Text = "Username is avaliable";
                    label4.ForeColor = System.Drawing.Color.Green;
                    break;
                case 1:
                    label4.Text = "Username is already taken";
                    label4.ForeColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    label4.Text = "Username is too long";
                    label4.ForeColor = System.Drawing.Color.Red;
                    break;
                case 3:
                    label4.Text = "Username is too short";
                    label4.ForeColor = System.Drawing.Color.Red;
                    break;
                case 4:
                    label4.Text = "Username contains spaces";
                    label4.ForeColor = System.Drawing.Color.Red;
                    break;
                default:
                    label4.Visible = false;
                    break;

            }

            label4.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (changeUsername.IsUsernameTaken(UsernameTextBox.Text) == 0 &&
                !string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                changeUsername.CreateNewUser(UsernameTextBox.Text,PasswordTextBox.Text);
                MessageBox.Show("User Created succesfully", "User Created", MessageBoxButtons.OK);
                this.Close();

            }

        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
