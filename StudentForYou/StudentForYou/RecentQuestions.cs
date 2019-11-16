using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using StudentForYou.RecentPosts;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class RecentQuestions : Form
    {
        int A = 1;
        int id;
        QuestionDetails details = new QuestionDetails();
        QuestionsDB db = new QuestionsDB();
        public RecentQuestions(int id)
        {
            InitializeComponent();
            this.id = id;
            List<QuestionDetails> questionList = db.GetQuestions();
            WriteToFlowLayoutPanel(questionList);
            button1.Text = "Likes  " + char.ConvertFromUtf32(0x2191);
            button2.Text = "Views  " + char.ConvertFromUtf32(0x2191);
            button3.Text = "Answers  " + char.ConvertFromUtf32(0x2191);
            newpostbtn.Click += delegate (object sender, EventArgs e)
            {
                newpostbtn_Click(sender, e, questionList);
            };

            button1.Click += delegate (object sender, EventArgs e)
            {
                button1_Click(sender, e, questionList);
            };

            button2.Click += delegate (object sender, EventArgs e)
            {
                button2_Click(sender, e, questionList);
            };

            button3.Click += delegate (object sender, EventArgs e)
            {
                button3_Click(sender, e, questionList);
            };
            txtSearch.TextChanged += delegate (object sender, EventArgs e)
            {
                txtSearch_TextChanged(sender, e, details , questionList);
            };
            recentquestionsbtn.Enabled = false;
        }



        public Button AddNewButton(int id, string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
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
            var answ = Int32.Parse(answers);
            var likeColor = Int32.Parse(likes);
            if (likeColor.IsLessThan(0))
            {
                btn.BackColor = Color.Tomato;
            }
            else if (answ.IsGreaterThan(0))
            {
                btn.BackColor = Color.LightGreen;
            }
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(id, sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                db.AddView(id);
            };
            return btn;
        }
        public Button AddNewLikesButton(int id, string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 2);
            btn.Text = "Likes: " + likes;
            btn.Height = 40;
            var answ = Int32.Parse(answers);
            var likeColor = Int32.Parse(likes);
            if (likeColor.IsLessThan(0))
            {
                btn.BackColor = Color.Tomato;
            }
            else if (answ.IsGreaterThan(0))
            {
                btn.BackColor = Color.LightGreen;
            }
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(id, sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                db.AddView(id);
            };

            return btn;
        }
        public Button AddNewViewsButton(int id, string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 3);
            btn.Text = "Views: " + views;
            btn.Height = 40;
            var answ = Int32.Parse(answers);
            var likeColor = Int32.Parse(likes);
            if (likeColor.IsLessThan(0))
            {
                btn.BackColor = Color.Tomato;
            }
            else if (answ.IsGreaterThan(0))
            {
                btn.BackColor = Color.LightGreen;
            }
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(id, sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                db.AddView(id);
            };
            return btn;
        }
        public Button AddNewAnswersButton(int id, string likes, string views, string answers, string question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 4);
            btn.Text = "Answers: " + answers;
            var answ = Int32.Parse(answers);
            var likeColor = Int32.Parse(likes);
            if (likeColor.IsLessThan(0))
            {
                btn.BackColor = Color.Tomato;
            }
            else if (answ.IsGreaterThan(0))
            {
                btn.BackColor = Color.LightGreen;
            }
            btn.Height = 40;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(id, sender, e, question, likes, views, answers, placeToReplace, questionList, details, postDate);
                db.AddView(id);
            };
            return btn;
        }

        private void newpostbtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            var newForm = new NewPostForm(questionList, id);
            newForm.Show();
            this.Close();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        { 
            var courses = new form1(id);
            courses.Show();
            this.Close();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var Profile = new UserProfile(id);
            Profile.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void button_click (int questionID, object sender, EventArgs e, string question, string likes, string views, string answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            var btn = sender as Button;
            var QuestionForm = new SelectedQuestionForm(id, questionID, question, likes, views, answers, placeToReplace, questionList, details, postDate);
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

        void WriteToFlowLayoutPanel (List<QuestionDetails> questionList)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < questionList.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(AddNewButton(questionList[i].questionID, questionList[i].questionLikes, questionList[i].questionViews, questionList[i].questionAnswers, questionList[i].question, i, questionList, details, questionList[i].currentDate));
                flowLayoutPanel1.Controls.Add(AddNewLikesButton(questionList[i].questionID, questionList[i].questionLikes, questionList[i].questionViews, questionList[i].questionAnswers, questionList[i].question, i, questionList, details, questionList[i].currentDate));
                flowLayoutPanel1.Controls.Add(AddNewViewsButton(questionList[i].questionID, questionList[i].questionLikes, questionList[i].questionViews, questionList[i].questionAnswers, questionList[i].question, i, questionList, details, questionList[i].currentDate));
                flowLayoutPanel1.Controls.Add(AddNewAnswersButton(questionList[i].questionID, questionList[i].questionLikes, questionList[i].questionViews, questionList[i].questionAnswers, questionList[i].question, i, questionList, details, questionList[i].currentDate));
            }
        }
        private void button1_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            if (button1.Text == "Likes  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new QuestionDetails.SortLikesAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button1.Text = "Likes " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button1.Text = "Likes  " + char.ConvertFromUtf32(0x2191);
                var sLD = new QuestionDetails.SortLikesDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);

            }
        }

        private void button2_Click(object sender, EventArgs e,List<QuestionDetails> questionList)
        {
            if (button2.Text == "Views  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new QuestionDetails.SortViewAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button2.Text = "Views  " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button2.Text = "Views  " + char.ConvertFromUtf32(0x2191);
                var sLD = new QuestionDetails.SortViewDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);
            }
        }

        private void button3_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            if (button3.Text == "Answers  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new QuestionDetails.SortAnswersAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button3.Text = "Answers  " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button3.Text = "Answers  " + char.ConvertFromUtf32(0x2191);
                var sLD = new QuestionDetails.SortAnswersDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e, QuestionDetails details, List<QuestionDetails> questionList)
        {
            List<QuestionDetails> tempList = details.SearchQuestion(questionList, txtSearch.Text);
            WriteToFlowLayoutPanel(tempList);
        }
        private void recentquestionsbtn_Click(object sender, EventArgs e)
        {

        }

        private void Newpostbtn_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
