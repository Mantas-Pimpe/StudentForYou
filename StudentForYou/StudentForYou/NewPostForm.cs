using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public partial class NewPostForm : Form
    {
        public NewPostForm()
        {
            InitializeComponent();
            questionBox.Text = "Enter your question";
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {

            String text = questiontxt.Text;
            using (StreamWriter writeText = new StreamWriter("RecentPosts.txt", true))
            {
                writeText.Write("0" + "," + "0" + "," + "0" + "," + text + Environment.NewLine);
            }
            RecentPostsForm rpf = new RecentPostsForm();
            rpf.Show();
            this.Close();
        }
    }
}
