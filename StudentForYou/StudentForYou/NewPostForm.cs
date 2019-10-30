using StudentForYou.RecentPosts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace StudentForYou
{
    public partial class NewPostForm : Form
    {
        private readonly string username = string.Empty;
        public NewPostForm(List<QuestionDetails> questionList,string username)
        {
            InitializeComponent();
            this.username = username;
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
            var newPost = new QuestionDetails();
            newPost.question = questiontxt.Text;
            newPost.answersForQuestion = " ";
            newPost.questionAnswers = "0";
            newPost.questionLikes = "0";
            newPost.questionViews = "0";
            newPost.currentDate = DateTime.Today;

            questionList.Add(newPost);
            var text = questiontxt.Text;
            using (StreamWriter writeText = new StreamWriter(@"Resources\recentquestions.txt", true))
            {
                writeText.Write("0" + "`" + "0" + "`" + "0" + "`" + text + "`" + " " + "`"+ newPost.currentDate + Environment.NewLine);
            }
            var rpf = new RecentQuestions(username);
            rpf.Show();
            this.Close();
        }

        private void questiontxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewPostForm_Load(object sender, EventArgs e)
        {

        }

        private void NewPostForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var rpf = new RecentQuestions(username);
            rpf.Show();
            this.Close();
        }
    }
}
