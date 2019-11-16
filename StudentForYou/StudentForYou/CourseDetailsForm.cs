using System;
using System.Windows.Forms;
using Studentforyousubjects;
using System.Diagnostics;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class CourseDetailsForm : Form
    {
        ProfileDB profileDB = new ProfileDB();
        CoursesDB coursesDB = new CoursesDB();
        Course course;
        int userID, courseID;
        public CourseDetailsForm(int courseID, int userID)
        {
            InitializeComponent();
            this.courseID = courseID;
            this.userID = userID;
            course = coursesDB.GetCourse(courseID);
            CourseDetailsNameBox.Text = course.name;
            CourseDetailsTextBox.Text = course.description;
            DisplayCourseDetails();

            /*uploader = new FileUploader(courseName);
            downloadsListView.Items.AddRange(uploader.UploadFiles());*/
        }
        public void DisplayCourseDetails()
        {
            CourseDetailsReviewsTextBox.Clear();
            var tempReviewInfo = coursesDB.GetReviews(courseID);

            foreach (Review item in tempReviewInfo)
            {
                CourseDetailsReviewsTextBox.AppendText(profileDB.GetUser(userID).username + ": " + item.text);
                CourseDetailsReviewsTextBox.AppendText(Environment.NewLine);
            }
        }
        private void CourseDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseDetailsSaveButton_Click(object sender, EventArgs e)
        {
          
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void CourseDetailsBackButton_Click(object sender, EventArgs e)
        {
            /*reader.UploadToFile(CourseDetailsTextBox.Text);*/
            this.DialogResult = DialogResult.OK;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void CourseDownloadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadClick(object sender, EventArgs e)
        {
            //downloadsListView.Items.Add(uploader.UploadSingleFile());
        }

        private void DownloadsListView_DoubleClick(object sender, EventArgs e)
        { 

            /*  if (downloadsListView.SelectedItems.Count > 0)
            {

                var selected = downloadsListView.SelectedItems[0];
                var selectedFilePath = selected.Tag.ToString();
                Process.Start(selectedFilePath);

            }
            */
        }

        private void CourseDetailsPostReviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var postReviewForm = new AddReviewForm(userID, courseID);
            postReviewForm.ShowDialog();
            DisplayCourseDetails();
            this.Show();
        }

        private void CourseDetailsReviewsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DifficultyLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
