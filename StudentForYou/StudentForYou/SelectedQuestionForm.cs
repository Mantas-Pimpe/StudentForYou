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
            AddLikeButton(870, 5, question, likes, views, answers, placeToReplace, questionList, details);
            lblInfo.Text = "Likes: " + likes + " views: " + views + " answers: " + answers;
            int value = postDate.Month;
            var enumDisplayStatus = (QuestionDetails.Months)value;
            string stringValue = enumDisplayStatus.ToString();
            lblDate.Text = postDate.Year + " " + stringValue + " " + postDate.Day;
            button1.Click += delegate (Object sender, EventArgs e)
            {
                button1_Click(sender, e, likes, views, answers, question, placeToReplace, questionList, details);
            };
            RefreshTextBox(placeToReplace, questionList);
        }

        void RefreshTextBox(int placeToReplace, List<QuestionDetails> questionList)
        {
            txtAnswers.Text = "";
            Random rnd = new Random();
            string line = questionList[placeToReplace].AnswersForQuestion;
            string[] splittedAnswers = line.Split('^');
            for (int i = 1; i < splittedAnswers.Length; i++)
            {
                int randomNumber = rnd.Next(555, 987587);
                txtAnswers.AppendText("User" + randomNumber + ": " + splittedAnswers[i]);
                txtAnswers.AppendText(Environment.NewLine);
            }
        }

        public System.Windows.Forms.Label AddNewLabel(string question)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(label);
            label.Size = new System.Drawing.Size(870, 30);
            label.Font = new Font("Arial", 16, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = question;
            return label;
        }

        public System.Windows.Forms.Button AddLikeButton(int xPos, int yPos, String question, String likes, String views, String answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Width = 60;
            btn.Location = new Point(xPos, yPos);
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = "Like";
            btn.Click += delegate (object sender, EventArgs e)
            {
                details.AddLike(questionList, placeToReplace);
            };
            btn.Click += new EventHandler(this.button_click);
            return btn;
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
                details.AddAnswers(questionList, placeToReplace, richTextBox1.Text);
            }
            richTextBox1.Text = "";
            RefreshTextBox(placeToReplace, questionList);
        }

        private void txtAnswers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
