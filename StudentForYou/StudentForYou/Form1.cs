using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//using StudentForYouRecentPosts;

namespace StudentForYou
{
    public partial class RecentPostsForm : Form
    {
        int A = 1;
        QuestionDetails details = new QuestionDetails();
        public RecentPostsForm()
        {
            InitializeComponent();
            List<QuestionDetails> questionList = details.getQuestionDetails();
            for (int i = 0; i < questionList.Count; i++)
            {
                flowLayoutPanel1.Controls.Add(AddNewButton(questionList[i].QuestionLikes, questionList[i].QuestionViews, questionList[i].QuestionAnswers, questionList[i].Question, i, questionList, details));
            }

            newpostbtn.Click += delegate (object sender, EventArgs e)
            {
                newpostbtn_Click(sender, e, questionList);
            };
        }


        private void newpostbtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            this.Close();
            NewPostForm newForm = new NewPostForm(questionList);
            newForm.Show();
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
                this.Close();
            };
            return btn;
        }


        private void coursesbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            form1 subjects = new form1();
            subjects.Show();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            form1 courses = new form1();
            this.Close();
            courses.Show();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            String Username = "Jeff";
            UserProfile Profile = new UserProfile(Username);
            this.Close();
            Profile.Show();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
        }

        void button_click (object sender, EventArgs e, string question, string likes, string views, string answers, int placeToReplace, List<QuestionDetails> questionList, QuestionDetails details)
        {
            Button btn = sender as Button;
            SelectedQuestionForm QuestionForm = new SelectedQuestionForm(question, likes, views, answers, placeToReplace, questionList, details);
            this.Close();
            QuestionForm.Show();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            this.Hide();
            chat.Show();
        }

        private void GroupChat_Click(object sender, EventArgs e)
        {
            GroupChat gchat = new GroupChat();
            this.Hide();
            gchat.Show();
        }

        private void RecentPostsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
