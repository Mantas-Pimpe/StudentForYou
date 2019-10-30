using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Studentforyousubjects;

namespace StudentForYou
{
    public partial class form1 : Form
    {
        ListViewInfosetter setter;
        private string username = string.Empty;
        int amountOfButtons = 0;
        public form1(string username)
        {
            InitializeComponent();
            this.username = username;
            setter = new ListViewInfosetter();
            
            coursebtn.Enabled = false;
            List<Course> templist = setter.ReadFileInfo();
            foreach (Course item in templist)
            {
                SubjectsLayoutPanel.Controls.Add(AddButton(item, amountOfButtons));
                SubjectsLayoutPanel.Controls.Add(AddIconButton(amountOfButtons));
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
            SubjectsLayoutPanel.Controls.Add(AddIconButton(amountOfButtons));
            amountOfButtons = amountOfButtons + 1;
            this.Show();
        }

        public Button AddIconButton(int numberofbuttons)
        {
            Button btn = new Button();
            SubjectsLayoutPanel.SetColumn(btn, 2);
            btn.Top = numberofbuttons * 40;
            btn.Width = 40;
            btn.BackgroundImage = Image.FromFile(@"Resources\chaticon.png");
            btn.Height = 40;
            btn.Left = 650;
            btn.Name = (numberofbuttons + 1).ToString();
            btn.Click += new EventHandler(IconButton_Click);
            return btn;
        }

        public void IconButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var button = sender as Button;
            var proc = System.Diagnostics.Process.Start(@"..\..\..\StudentForYou.ChatServer\bin\Debug\StudentForYou.ChatServer.exe", button.Name);
            var gchat = new GroupChatForm(this, username, Int32.Parse(button.Name), proc);
            gchat.ShowDialog();
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

            //SubjectsLayoutPanel.ColumnCount = 2;
            //SubjectsLayoutPanel.AutoScroll = true;
            /*SubjectsLayoutPanel.FlowDirection = FlowDirection.TopDown;
            SubjectsLayoutPanel.WrapContents = false;*/
            //SubjectsLayoutPanel.AutoSize = false;
        }
        public Button AddButton(Course d, int refbuttonumber)
        {
            var buttonNumber = refbuttonumber;
            var courseName = d.Name;
            var courseDescription = d.Description;
            var difficulty = d.Difficulty;

            Button btn = new Button();
            SubjectsLayoutPanel.SetColumn(btn, 1);
            btn.Top = buttonNumber * 40;
            btn.Width = 1140;
            btn.Height = 40;
            btn.Left = 15;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = courseName + "difficulty: " + difficulty;
            btn.Name = courseName;
            btn.Click += new EventHandler(Button_Click);
            return btn;
        }

        public void Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            var button = sender as Button;
            var downloadsForm = new CourseDetailsForm(button.Name,username);
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
                var tempIconButton = AddIconButton(amountOfButtons);
                var tempCourseButton =AddButton(courseToBeAdded,amountOfButtons);
                tempIconButton.Top = tempCourseButton.Top;
                SubjectsLayoutPanel.Controls.Add(tempCourseButton);
                SubjectsLayoutPanel.Controls.Add(tempIconButton);
            }
            this.Show();
        }

        private void Coursebtn_Click_1(object sender, EventArgs e)
        {

        }
    }

}