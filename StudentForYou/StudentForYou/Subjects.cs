using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Studentforyousubjects;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class form1 : Form
    {
        int userID;
        int amountOfButtons = 0;
        CoursesDB db = new CoursesDB();
        public form1(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            coursebtn.Enabled = false;
            DisplayList();

        }

        private void DisplayList()
        {
            SubjectsLayoutPanel.Controls.Clear();
            List<Course> list = db.GetCourses();
            foreach (Course item in list)
            {
                SubjectsLayoutPanel.Controls.Add(AddButton(item, amountOfButtons));
                SubjectsLayoutPanel.Controls.Add(AddDifficultyButton(item, amountOfButtons));
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
            var subjectAdder = new SubjectAdder();
            var subjectForm = new AddSubjectForm(subjectAdder);
            if (subjectForm.ShowDialog() == DialogResult.OK)
            {
                DisplayList();
            }
            this.Show();
        }

        public Button AddIconButton(int numberofbuttons)
        {
            var btn = new Button();
            SubjectsLayoutPanel.SetColumn(btn, 3);
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
            var gchat = new GroupChatForm(this, userID, Int32.Parse(button.Name), proc);
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

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }

        private void SubjectsLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        public Button AddButton(Course d, int refButtonNumber)
        {
            var buttonNumber = refButtonNumber;
            var courseName = d.name;
            var courseDescription = d.description;
            var difficulty = d.difficulty;
            var btn = new Button();
            SubjectsLayoutPanel.SetColumn(btn, 1);
            btn.Top = buttonNumber * 40;
            btn.Width = 1050;
            btn.Height = 40;
            btn.Left = 15;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = courseName;
            btn.Name = courseName;
            btn.Click += delegate (object sender, EventArgs e)
            {
                Button_Click(sender, e, d.courseID);
            };
            return btn;
        }
        public Button AddDifficultyButton(Course d, int refbuttonumber)
        {
            var buttonNumber = refbuttonumber;
            var courseName = d.name;
            var courseDescription = d.description;
            var difficulty = d.difficulty;
            var btn = new Button();
            SubjectsLayoutPanel.SetColumn(btn, 2);
            btn.Top = buttonNumber * 40;
            btn.Width = 100;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = "Difficulty: " + difficulty;
            btn.Name = courseName;
            btn.Click += delegate (object sender, EventArgs e)
            {
                Button_Click(sender, e, d.courseID);
            };
            return btn;
        }

        public void Button_Click(object sender, EventArgs e, int courseID)
        {
            this.Hide();
            var downloadsForm = new CourseDetailsForm(courseID, userID);
            downloadsForm.ShowDialog();
            this.Show();
        }

        private void Coursebtn_Click(object sender, EventArgs e)
        {

        }

        private void Recentquestionsbtn_Click_1(object sender, EventArgs e)
        {
            var rpF = new RecentQuestions(userID);
            rpF.Show();
            this.Close();
        }

        private void Profilebtn_Click_1(object sender, EventArgs e)
        {
            var Profile = new UserProfile(userID);
            Profile.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var subjectAdder = new SubjectAdder();
            var subjectForm = new AddSubjectForm(subjectAdder);
            if (subjectForm.ShowDialog() == DialogResult.OK)
            {
                DisplayList();
            }
            this.Show();
        }

        private void Coursebtn_Click_1(object sender, EventArgs e)
        {

        }
    }

}