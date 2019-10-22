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
//using StudentForYouRecentPosts;

namespace StudentForYou
{
    public partial class NewPostForm : Form
    {
        public NewPostForm(List<QuestionDetails> questionList)
        {
            InitializeComponent();
            questionBox.Text = "Enter your question";
            SaveBtn.Click += delegate (Object sender, EventArgs e)
            {
                SaveBtn_Click(sender, e, questionList);
            };
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            QuestionDetails newPost = new QuestionDetails();
            newPost.Question = questiontxt.Text;
            newPost.AnswersForQuestion = " ";
            newPost.QuestionAnswers = "0";
            newPost.QuestionLikes = "0";
            newPost.QuestionViews = "0";

            questionList.Add(newPost);
            String text = questiontxt.Text;
            using (StreamWriter writeText = new StreamWriter(@"Resources\recentquestions.txt", true))
            {
                writeText.Write("0" + "`" + "0" + "`" + "0" + "`" + text + "`" + " " + Environment.NewLine);
            }
            RecentPostsForm rpf = new RecentPostsForm();
            rpf.Show();
            this.Close();
        }

        private void questiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPostForm_Load(object sender, EventArgs e)
        {

        }
    }
}
