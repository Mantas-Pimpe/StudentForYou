using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using StudentForYou.RecentPosts;
using System.Collections.Generic;

namespace StudentForYou
{
    public partial class RecentQuestions : Form
    {
        int A = 1;
        private string username = string.Empty;
        QuestionDetails details = new QuestionDetails();
        public RecentQuestions(string username)
        {
            InitializeComponent();
            this.username = username;
            List<QuestionDetails> questionList = details.getQuestionDetails();
            for (int i = 0; i < questionList.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(AddNewButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details));
            }

            newpostbtn.Click += delegate (object sender, EventArgs e)
            {
                newpostbtn_Click(sender, e, questionList);
            };
            recentquestionsbtn.Enabled = false;
        }



        public System.Windows.Forms.Button AddNewButton(string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = A * 40;
            btn.Width = 1120;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = "''" + question + "''";
            A += 1;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question, likes, views, answers, placeToReplace, questionList, details);
                details.AddViews(questionList, placeToReplace);
                //this.Close();
            };
            return btn;
        }


        private void newpostbtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            NewPostForm newForm = new NewPostForm(questionList, username);
            newForm.Show();
            this.Close();
        }

        private void coursesbtn_Click(object sender, EventArgs e)
        {
            var subjects = new form1(username);
            subjects.Show();
            this.Close();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        { 
            var courses = new form1(username);
            courses.Show();
            this.Close();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var Profile = new UserProfile(username);
            Profile.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
        }

        void button_click (object sender, EventArgs e, string question, string likes, string views, string answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details)
        {
            var btn = sender as Button;
            var QuestionForm = new SelectedQuestionForm(question, likes, views, answers, placeToReplace, questionList, details, username);
            QuestionForm.Show();
            this.Hide();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            var chat = new ChatForm(this);
            this.Hide();
            chat.Show();
        }

        private void GroupChat_Click(object sender, EventArgs e)
        {
            var gchat = new GroupChatForm(this, username);
            this.Hide();
            gchat.Show();
        }

        private void RecentPostsForm_Load(object sender, EventArgs e)
        {

        }

        private void RecentQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RecentQuestions_Load(object sender, EventArgs e)
        {

        }
    }
}
