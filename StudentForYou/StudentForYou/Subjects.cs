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
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class form1 : Form
    {
        listviewinfosetter setter;
        public form1()
        {
            InitializeComponent();
            setter = new listviewinfosetter();
           
            List<Course> templist=  setter.Readfileinfo();
             foreach(Course item in templist)
              {
                var fullcoursedetails = new ListViewItem(new[] { item.Name, item.Description, item.Difficulty });
                listView1.Items.Add(fullcoursedetails);
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
            this.Hide();
        SubjectAdder addstuff = new SubjectAdder();
            AddSubjectForm subjectform = new AddSubjectForm(addstuff);
            subjectform.ShowDialog();
            listView1.Items.Clear();
            List<Course> templist = setter.Readfileinfo();
            foreach (Course item in templist)
            {
                var fullcoursedetails = new ListViewItem(new[] { item.Name, item.Description, item.Difficulty });
                listView1.Items.Add(fullcoursedetails);
            }
            this.Show();
            
              
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
            UserProfile Profile = new UserProfile(Username);
            this.Hide();
            Profile.Show();
        }
    }

}