using StudentForYou.RecentPosts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using StudentForYou.DB;

namespace StudentForYou
{
    
    public partial class SelectedQuestionForm : Form
    {
        User user;
        Question question;
        QuestionsDB questionsDB = new QuestionsDB();
        ProfileDB profileDB = new ProfileDB();
        public SelectedQuestionForm(Question question, User user)
        {
            InitializeComponent();
            this.user = user;
            this.question = question;
            AddNewLabel(question.questionName);
            AddNewButton(1173, 632);
            lblInfo.Text = "Likes: " + question.questionLikes + " views: " + question.questionViews + " answers: " + question.questionAnswers;
            var value = question.questionCreationDate.Month;
            var enumDisplayStatus = (Question.Months)value;
            var stringValue = enumDisplayStatus.ToString();
            lblDate.Text = question.questionCreationDate.Year + " " + stringValue + " " + question.questionCreationDate.Day;
            RefreshTextBox();
            button1.Click += delegate (Object sender, EventArgs e)
            {
                button1_Click(sender, e);
            };
            btnDislike.Click += delegate (Object sender, EventArgs e)
            {
                btnDislike_Click(sender, e);
            };
            btnLike.Click += delegate (Object sender, EventArgs e)
            {
                btnLike_Click(sender, e);
            };
        }

        void RefreshTextBox()
        {
            txtAnswers.Text = "";
            List<Comment> list = questionsDB.GetComments(question);
            for (int i = 0; i < list.Count; i++)
            {
                txtAnswers.Text = txtAnswers.Text + list[i].commentDate + "      " + profileDB.GetUser(list[i].userID).username + ": " + list[i].commentText + Environment.NewLine;
            }
        }

        public Label AddNewLabel(string question)
        {
            Label label = new Label();
            this.Controls.Add(label);
            label.Size = new Size(750, 50);
            label.Font = new Font("Arial", 16, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = question;
            return label;
        }

        public Button AddNewButton(int xPos, int yPos)
        {
            Button btn = new Button();
            this.Controls.Add(btn);
            btn.Width = 60;
            btn.Text = "Back";
            btn.Location = new Point(xPos, yPos);
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Click += new EventHandler(this.button_click);
            return btn;
        }

        void button_click (object sender, EventArgs e)
        {
            var btn = sender as Button;
            var rpf = new RecentQuestions(user);
            this.Close();
            rpf.Show();
        }
        private void SelectedQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != String.Empty)
            {
                questionsDB.InsertIntoComments(question, richTextBox1.Text, DateTime.Now, user);
            }
            richTextBox1.Clear();
            RefreshTextBox();
        }

        private void txtAnswers_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDislike_Click(object sender, EventArgs e)
        {
            questionsDB.AddDislike(question);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            questionsDB.AddLike(question);
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
