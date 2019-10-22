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
        int amountOfButtons = 0;
        public form1(string username)
        {
            InitializeComponent();
            this.username = username;
            setter = new ListViewInfosetter();
            adder = new ButtonAdder();
            //coursebtn.Enabled = false;
            List<Course> templist = setter.ReadFileInfo();
            foreach (Course item in templist)
            {
                SubjectsLayoutPanel.Controls.Add(AddButton(item, amountOfButtons));
                SubjectsLayoutPanel.Controls.Add(adder.AddIconButton(amountOfButtons));
   
                amountOfButtons = amountOfButtons + 1;



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
                SubjectsLayoutPanel.Controls.Add(AddButton(Tempcourse, amountOfButtons));
            SubjectsLayoutPanel.Controls.Add(adder.AddIconButton(amountOfButtons));
            amountOfButtons = amountOfButtons + 1;
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
            }

            private void profilebtn_Click(object sender, EventArgs e)
            {
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
            btn.Width = 1120;
            btn.Height = 40;
            btn.Left = 15;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = courseName;
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

        private void Coursebtn_Click(object sender, EventArgs e)
        {

        }

        private void Recentquestionsbtn_Click_1(object sender, EventArgs e)
        {
            var rpF = new RecentQuestions(username);
            rpF.Show();
            this.Close();
        }

        private void Profilebtn_Click_1(object sender, EventArgs e)
        {
            var Profile = new UserProfile(username);
            Profile.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var subjectAdder = new SubjectAdder();
            var addSubjectForm = new AddSubjectForm(subjectAdder);
            if(addSubjectForm.ShowDialog() ==DialogResult.OK)
            {
                var courseToBeAdded = new Course();
                courseToBeAdded.Name = addSubjectForm.CourseNameTextBox.Text;
                courseToBeAdded.Description = addSubjectForm.CourseDescriptionTextBox.Text;
                courseToBeAdded.Difficulty = addSubjectForm.DifficultyTextBox.Text;
                amountOfButtons = amountOfButtons + 1;
                var tempIconButton =adder.AddIconButton(amountOfButtons);
                var tempCourseButton =AddButton(courseToBeAdded,amountOfButtons);
                tempIconButton.Top = tempCourseButton.Top;
                SubjectsLayoutPanel.Controls.Add(tempCourseButton);
                SubjectsLayoutPanel.Controls.Add(tempIconButton);
            }
            this.Show();
        }
    }

    }