using System;
using System.Windows.Forms;

namespace StudentForYou
{
    public partial class AddReviewForm : Form
    {
        string username = String.Empty;
        public string reviewText { get; set; }
        public AddReviewForm(string passedUsername)
        {
            InitializeComponent();
            this.Name = "Add review";
            username = passedUsername;
        }

        private void CancelReviewButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void PostReviewButton_Click(object sender, EventArgs e)
        {
            if (PostReviewTextBox.Text != String.Empty)
                
                reviewText = username + ": " + PostReviewTextBox.Text+ System.Environment.NewLine;
                this.DialogResult = DialogResult.OK;
            }

        private void AddReviewForm_Load(object sender, EventArgs e)
        {

        }
    }
    }

