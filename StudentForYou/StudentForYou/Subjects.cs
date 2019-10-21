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
        ListViewInfosetter setter;
        ButtonAdder adder;
        private string username = string.Empty;
        int amountofbuttons = 0;
        public form1(string username)
        {
            InitializeComponent();
            this.username = username;
            setter = new ListViewInfosetter();
            adder = new ButtonAdder();

            List<Course> templist = setter.ReadFileInfo();
            foreach (Course item in templist)
            {
                SubjectsLayoutPanel.Controls.Add(AddButton(item, amountofbuttons));
                SubjectsLayoutPanel.Controls.Add(adder.AddIconButton(amountofbuttons));
   
                amountofbuttons = amountofbuttons + 1;



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
            var SubjectAdder = new SubjectAdder();
            var SubjectForm = new AddSubjectForm(SubjectAdder);
                var Tempcourse = new Course();
                if (SubjectForm.ShowDialog() == DialogResult.OK)
                {
                Tempcourse.Description = SubjectForm.CourseDescriptionTextBox.Text;
                Tempcourse.Difficulty = SubjectForm.DifficultyTextBox.Text;
                Tempcourse.Name = SubjectForm.CourseNameTextBox.Text;

                }
                SubjectsLayoutPanel.Controls.Add(AddButton(Tempcourse, amountofbuttons));
            SubjectsLayoutPanel.Controls.Add(adder.AddIconButton(amountofbuttons));
            amountofbuttons = amountofbuttons + 1;
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

                var rpF = new RecentQuestions(username);
                rpF.Show();
                this.Close();
            }

            private void profilebtn_Click(object sender, EventArgs e)
            {
                var Profile = new UserProfile(username);
                Profile.Show();
                this.Close();
            }

            private void Coursesbtn_Click(object sender, EventArgs e)
            {
                /* if(listView1.SelectedItems[0].Text!=null)
                 {
                     var Detailsform = new CourseDetailsForm(listView1.SelectedItems[0].Text);
                     this.Hide();
                     Detailsform.ShowDialog();
                     this.Show();
                 }
                 */

            }

            private void Form1_FormClosed(object sender, FormClosedEventArgs e)
            {
                if (Application.OpenForms.OfType<Form>().Count() == 1)
                    Application.Exit();
            }

            private void SubjectsLayoutPanel_Paint(object sender, PaintEventArgs e)
            {
                SubjectsLayoutPanel.AutoScroll = true;
                SubjectsLayoutPanel.FlowDirection = FlowDirection.TopDown;
                SubjectsLayoutPanel.WrapContents = false;

            }
        public Button AddButton(Course d, int refbuttonumber)
        {
            var buttonNumber = refbuttonumber;
            var courseName = d.Name;
            var courseDescription = d.Description;
            var difficulty = d.Difficulty;

            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            btn.Top = buttonNumber * 40;
            btn.Width = 800;
            btn.Height = 40;
            btn.Left = 15;
            btn.Text = courseName + "Description :" + courseDescription + "Difficulty" + difficulty;
            btn.Name = courseName;
            btn.Click += new EventHandler(Button_Click);
            return btn;
        }


        public void Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Button button = sender as Button;
            CourseDetailsForm downloadsForm = new CourseDetailsForm(button.Name);
            downloadsForm.ShowDialog();
            this.Show();


        }
    }

    }