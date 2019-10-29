using StudentForYou.RecentPosts;
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
    
    public partial class SelectedQuestionForm : Form
    {

        private string username = string.Empty;
        public SelectedQuestionForm(String question, String likes, String views, String answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details, string username, DateTime postDate)
        {
            InitializeComponent();
            this.username = username;
            AddNewLabel(question);
            AddNewButton(850, 530);
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
                btnDislike_Click(sender, e, questionList, placeToReplace, details, likes, views, answers);
            };
            btnLike.Click += delegate (Object sender, EventArgs e)
            {
                btnLike_Click(sender, e, questionList, placeToReplace, details, likes, views, answers);
            };
        }

        void RefreshTextBox(int placeToReplace, List<QuestionDetails> questionList)
        {
            txtAnswers.Text = "";
            var line = questionList[placeToReplace].answersForQuestion;
            string[] splittedAnswers = line.Split('^');
            for (int i = 1; i < splittedAnswers.Length; i++)
            {
                txtAnswers.AppendText(splittedAnswers[i]);
                txtAnswers.AppendText(Environment.NewLine);
            }
        }

        public System.Windows.Forms.Label AddNewLabel(string question)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(label);
            label.Size = new System.Drawing.Size(750, 50);
            label.Font = new Font("Arial", 16, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = question;
            return label;
        }

        public System.Windows.Forms.Button AddNewButton(int xPos, int yPos)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
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
            var rpf = new RecentQuestions(username);
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
                details.AddAnswers(questionList, placeToReplace, username + " : " + richTextBox1.Text, ref answers);
                lblInfo.Text = "Likes: " + likes + " views: " + views + " answers: " + answers;
            }
            richTextBox1.Clear();
            RefreshTextBox(placeToReplace, questionList);
        }

        private void txtAnswers_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnDislike_Click(object sender, EventArgs e, List<QuestionDetails> questionList, int placeToReplace, QuestionDetails details, String likes, String views, String answers)
        {
            details.AddDislike(questionList, placeToReplace, ref likes);
            lblInfo.Text = "Likes: " + likes + " views: " + views + " answers: " + answers;
        }

        private void btnLike_Click(object sender, EventArgs e, List<QuestionDetails> questionList, int placeToReplace, QuestionDetails details, String likes, String views, String answers)
        {
            details.AddLike(questionList, placeToReplace, ref likes);
            lblInfo.Text = "Likes: " + likes + " views: " + views + " answers: " + answers;
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        private void button1_Click(object sender, EventArgs e)

        {

        }
    }
}
