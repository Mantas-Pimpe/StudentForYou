using System;
using System.Windows.Forms;
using Studentforyousubjects;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class CourseDetailsForm : Form
    {
        ProfileDB profileDB = new ProfileDB();
        CoursesDB coursesDB = new CoursesDB();
        Course course;
        User user;
        public CourseDetailsForm(Course course, User user)
        {
            InitializeComponent();
            this.course = course;
            this.user = user;
            CourseDetailsNameBox.Text = course.name;
            CourseDetailsTextBox.Text = course.description;
            DisplayCourseDetails();
        }
        public void DisplayCourseDetails()
        {
            CourseDetailsReviewsTextBox.Clear();
            var tempReviewInfo = coursesDB.GetReviews(course.courseID);

            foreach (Review item in tempReviewInfo)
            {
                CourseDetailsReviewsTextBox.AppendText(profileDB.GetUser(user.userID).username + ": " + item.text);
                CourseDetailsReviewsTextBox.AppendText(Environment.NewLine);
            }

            downloadsListView.Clear();
            var tempDownloadsList = coursesDB.GetFiles(course.courseID);
            foreach (FileCourse item in tempDownloadsList)
            {
                var tmp = new ListViewItem(item.fileName);
                tmp.Tag = item.file;
                downloadsListView.Items.Add(tmp);
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
            var uploader = new FileUploader();
            coursesDB.UploadFile(user, course, uploader.UploadSingleFile(), DateTime.Now);
            DisplayCourseDetails();
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
            var postReviewForm = new AddReviewForm(user, course);
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
