using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using StudentForYou.RecentPosts;

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
                flowLayoutPanel1.Controls.Add(AddNewButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details, questionList[i].CurrentDate));
                flowLayoutPanel1.Controls.Add(AddNewLikesButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details, questionList[i].CurrentDate));
                flowLayoutPanel1.Controls.Add(AddNewViewsButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details, questionList[i].CurrentDate));
                flowLayoutPanel1.Controls.Add(AddNewAnswersButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details, questionList[i].CurrentDate));
            }

            newpostbtn.Click += delegate (object sender, EventArgs e)
            {
                newpostbtn_Click(sender, e, questionList);
            };
            recentquestionsbtn.Enabled = false;
        }



        public Button AddNewButton(string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            this.Controls.Add(btn);
            flowLayoutPanel1.SetColumn(btn, 1);
            btn.Width = 1000;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = question;
            A += 1;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                details.AddViews(questionList, placeToReplace);
            };
            return btn;
        }
        public Button AddNewLikesButton(string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 2);
            btn.Text = "Likes: " + likes;
            btn.Height = 40;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                details.AddViews(questionList, placeToReplace);
            };
            return btn;
        }
        public Button AddNewViewsButton(string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 3);
            btn.Text = "Views: " + views;
            btn.Height = 40;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                details.AddViews(questionList, placeToReplace);
            };
            return btn;
        }
        public Button AddNewAnswersButton(string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 4);
            btn.Text = "Answers: " + answers;
            btn.Height = 40;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                details.AddViews(questionList, placeToReplace);
            };
            return btn;
        }

        private void newpostbtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            var newForm = new NewPostForm(questionList, username);
            newForm.Show();
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

        }

        void button_click (object sender, EventArgs e, string question, string likes, string views, string answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = sender as Button;
            var QuestionForm = new SelectedQuestionForm(question, likes, views, answers, placeToReplace, questionList, details, username, postDate);
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
