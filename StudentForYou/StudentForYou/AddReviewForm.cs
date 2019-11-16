using System;
using System.Windows.Forms;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class AddReviewForm : Form
    {
        int userID;
        int courseID;
        public string reviewText { get; set; }

        ProfileDB profileDB = new ProfileDB();
        CoursesDB coursesDB = new CoursesDB();
        public AddReviewForm(int userID, int courseID)
        {
            InitializeComponent();
            this.Name = "Add review";
            this.userID = userID;
            this.courseID = courseID;
        }

        private void CancelReviewButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PostReviewButton_Click(object sender, EventArgs e)
        {
            if (PostReviewTextBox.Text != String.Empty)
                coursesDB.InsertIntoReviews(courseID, userID, PostReviewTextBox.Text, DateTime.Now);
                this.DialogResult = DialogResult.OK;
            }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

