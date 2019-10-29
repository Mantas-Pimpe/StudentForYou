using System;
using System.Windows.Forms;
using Studentforyousubjects;
using System.Diagnostics;

namespace StudentForYou
{
    public partial class CourseDetailsForm : Form
    {
        DescriptionReader reader;
        string nameOfCourse;
        string username = String.Empty;
        FileUploader uploader;
        public CourseDetailsForm(string courseName,string passedUsername)
        {
            InitializeComponent();
            username = passedUsername;
            nameOfCourse = courseName;
            reader = new DescriptionReader(courseName);
            CourseDetailsNameBox.Text = courseName;
            CourseDetailsTextBox.Text = reader.ReadDescription();
            var tempReviewInfo = reader.ReadReviews();
            
            foreach (string review in tempReviewInfo)
            {
                CourseDetailsReviewsTextBox.AppendText(review);
                CourseDetailsReviewsTextBox.AppendText(System.Environment.NewLine);
            }

            uploader = new FileUploader(courseName);
            downloadsListView.Items.AddRange(uploader.UploadFiles());
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
            reader.UploadToFile(CourseDetailsTextBox.Text);
            this.DialogResult = DialogResult.OK;
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var downloadsForm = new CourseDownloads(nameOfCourse);
            downloadsForm.ShowDialog();
            this.Show();
        }

        private void CourseDownloadsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UploadClick(object sender, EventArgs e)
        {
            downloadsListView.Items.Add(uploader.UploadSingleFile());
        }

        private void DownloadsListView_DoubleClick(object sender, EventArgs e)
        { 

              if (downloadsListView.SelectedItems.Count > 0)
            {

                var selected = downloadsListView.SelectedItems[0];
                var selectedFilePath = selected.Tag.ToString();
                Process.Start(selectedFilePath);

            }
            
        }

        private void CourseDetailsPostReviewButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var postReviewForm = new AddReviewForm(username);
            postReviewForm.ShowDialog();
           if(postReviewForm.DialogResult==DialogResult.OK)
            {
                reader.UploadReviews(postReviewForm.reviewText);
                CourseDetailsReviewsTextBox.AppendText(postReviewForm.reviewText);

              
            }
            this.Show();

           
        }
    }
}
