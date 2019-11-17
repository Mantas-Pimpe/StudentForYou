using System;
using System.Windows.Forms;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class AddReviewForm : Form
    {
        User user;
        Course course;
        public string reviewText { get; set; }

        CoursesDB coursesDB = new CoursesDB();
        public AddReviewForm(User user, Course course)
        {
            InitializeComponent();
            this.Name = "Add review";
            this.user = user;
            this.course = course;
        }

        private void CancelReviewButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PostReviewButton_Click(object sender, EventArgs e)
        {
            if (PostReviewTextBox.Text != String.Empty)
                coursesDB.InsertIntoReviews(course.courseID, user.userID, PostReviewTextBox.Text, DateTime.Now);
                this.DialogResult = DialogResult.OK;
            }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

