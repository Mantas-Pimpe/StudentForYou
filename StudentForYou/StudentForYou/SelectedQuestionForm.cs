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
        int questionID, id;
        QuestionsDB questionsDB = new QuestionsDB();
        ProfileDB profileDB = new ProfileDB();
        public SelectedQuestionForm(int id, int questionID, String question, String likes, String views, String answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, DateTime postDate)
        {
            InitializeComponent();
            this.id = id;
            this.questionID = questionID;
            AddNewLabel(question);
            AddNewButton(1173, 632);
            lblInfo.Text = "Likes: " + likes + " views: " + views + " answers: " + answers;
            var value = postDate.Month;
            var enumDisplayStatus = (QuestionDetails.Months)value;
            var stringValue = enumDisplayStatus.ToString();
            lblDate.Text = postDate.Year + " " + stringValue + " " + postDate.Day;
            RefreshTextBox(placeToReplace, questionList);
            button1.Click += delegate (Object sender, EventArgs e)
            {
                button1_Click(sender, e, likes, views, answers, question, placeToReplace, questionList, details);
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

        void RefreshTextBox(int placeToReplace, List<QuestionDetails> questionList)
        {
            txtAnswers.Text = "";
            List<Comment> list = questionsDB.GetComments(questionID);
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
            var rpf = new RecentQuestions(id);
            this.Close();
            rpf.Show();
        }
        private void SelectedQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, String likes, String views, String answers, String question, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details)
        {
            if (richTextBox1.Text != String.Empty)
            {
                questionsDB.InsertIntoComments(qns_id: questionID, com_text: richTextBox1.Text, com_creation_date: DateTime.Now, id);
            }
            richTextBox1.Clear();
            RefreshTextBox(placeToReplace, questionList);
        }

        private void txtAnswers_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDislike_Click(object sender, EventArgs e)
        {
            questionsDB.AddDislike(id);
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            questionsDB.AddLike(id);
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)

        {

        }
    }
}
