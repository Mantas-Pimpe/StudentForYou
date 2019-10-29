using Studentforyousubjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            
        }
    }

