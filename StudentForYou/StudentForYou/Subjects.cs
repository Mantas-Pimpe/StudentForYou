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
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            List<string> data = File.ReadAllLines(@"Resources\allcourses.txt").ToList();
            foreach (string d in data)
            {
                string[] items = d.Split(new char[] { ',' },
                       StringSplitOptions.RemoveEmptyEntries);
                listView1.Items.Add(new ListViewItem(items));
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
            
              
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void recentquestionsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecentPostsForm rpF = new RecentPostsForm();
            rpF.Show();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            String Username = "Jeff";
            UserProfile Profile = new UserProfile(Username,this);
            this.Hide();
            Profile.Show();
        }
    }
}
