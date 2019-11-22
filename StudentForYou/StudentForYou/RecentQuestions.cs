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
        User user;
        Question details = new Question();
        ProfileDB profileDB = new ProfileDB();
        QuestionsDB db = new QuestionsDB();
        public RecentQuestions(User user)
        {
            InitializeComponent();
            this.user = user;
            List<Question> questionList = db.GetQuestions();
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



        public Button AddNewButton(Question question)
        {
            var btn = new Button();
            this.Controls.Add(btn);
            flowLayoutPanel1.SetColumn(btn, 1);
            btn.Width = 1000;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = question.questionText;
            A += 1;
            var answ = question.questionAnswers;
            var likeColor = question.questionLikes;
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
                button_click(sender, e, question);
                db.AddView(question);
            };
            return btn;
        }
        public Button AddNewLikesButton(Question question)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 2);
            btn.Text = "Likes: " + question.questionLikes;
            btn.Height = 40;
            var answ = question.questionAnswers;
            var likeColor = question.questionLikes;
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
                button_click(sender, e, question);
                db.AddView(question);
            };

            return btn;
        }
        public Button AddNewViewsButton(Question question)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 3);
            btn.Text = "Views: " + question.questionViews;
            btn.Height = 40;
            var answ = question.questionAnswers;
            var likeColor = question.questionLikes;
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
                button_click(sender, e, question);
                db.AddView(question);
            };
            return btn;
        }
        public Button AddNewAnswersButton(Question question)
        {
            var btn = new Button();
            flowLayoutPanel1.SetColumn(btn, 4);
            btn.Text = "Answers: " + question.questionAnswers;
            var answ = question.questionAnswers;
            var likeColor = question.questionLikes;
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
                button_click(sender, e, question);
                db.AddView(question);
            };
            return btn;
        }

        private void newpostbtn_Click(object sender, EventArgs e, List<Question> questionList)
        {
            var newForm = new NewPostForm(questionList, user);
            newForm.Show();
            this.Close();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        { 
            var courses = new form1(user);
            courses.Show();
            this.Close();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            var Profile = new UserProfile(user);
            Profile.Show();
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        void button_click (object sender, EventArgs e, Question question)
        {
            var btn = sender as Button;
            var QuestionForm = new SelectedQuestionForm(question, user);
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

        void WriteToFlowLayoutPanel (List<Question> questionList)
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < questionList.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(AddNewButton(questionList[i]));
                flowLayoutPanel1.Controls.Add(AddNewLikesButton(questionList[i]));
                flowLayoutPanel1.Controls.Add(AddNewViewsButton(questionList[i]));
                flowLayoutPanel1.Controls.Add(AddNewAnswersButton(questionList[i]));
            }
        }
        private void button1_Click(object sender, EventArgs e, List<Question> questionList)
        {
            if (button1.Text == "Likes  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new Question.SortLikesAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button1.Text = "Likes " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button1.Text = "Likes  " + char.ConvertFromUtf32(0x2191);
                var sLD = new Question.SortLikesDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);

            }
        }

        private void button2_Click(object sender, EventArgs e,List<Question> questionList)
        {
            if (button2.Text == "Views  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new Question.SortViewAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button2.Text = "Views  " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button2.Text = "Views  " + char.ConvertFromUtf32(0x2191);
                var sLD = new Question.SortViewDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);
            }
        }

        private void button3_Click(object sender, EventArgs e, List<Question> questionList)
        {
            if (button3.Text == "Answers  " + char.ConvertFromUtf32(0x2191))
            {
                var sLA = new Question.SortAnswersAscending();
                questionList.Sort(sLA);
                WriteToFlowLayoutPanel(questionList);
                button3.Text = "Answers  " + char.ConvertFromUtf32(0x2193);
            }
            else
            {
                button3.Text = "Answers  " + char.ConvertFromUtf32(0x2191);
                var sLD = new Question.SortAnswersDescending();
                questionList.Sort(sLD);
                WriteToFlowLayoutPanel(questionList);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e, Question details, List<Question> questionList)
        {
            List<Question> tempList = details.SearchQuestion(questionList, txtSearch.Text);
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
