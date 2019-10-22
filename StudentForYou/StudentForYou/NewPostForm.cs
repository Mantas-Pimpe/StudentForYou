using StudentForYou.RecentPosts;
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
            /*String text = questiontxt.Text;
            using (StreamWriter writeText = new StreamWriter(@"Resources\recentquestions.txt", true))
            {
                writeText.Write("0" + "," + "0" + "," + "0" + "," + text + Environment.NewLine);
            }*/


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
