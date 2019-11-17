using StudentForYou.DB;
using StudentForYou.RecentPosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace StudentForYou
{
    public partial class NewPostForm : Form
    {
        User user;
        public NewPostForm(List<Question> questionList, User user)
        {
            InitializeComponent();
            this.user = user;
            questionBox.Text = "Enter your question";
            SaveBtn.Click += delegate (Object sender, EventArgs e)
            {
                SaveBtn_Click(sender, e, questionList);
            };
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e, List<Question> questionList)
        {
            var db = new QuestionsDB();
            db.InsertIntoQuestions(qns_name: questiontxt.Text, qns_text: questiontxt.Text, qns_creation_date: DateTime.Now, qns_user_id: user.userID);

            var rpf = new RecentQuestions(user);
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
            var rpf = new RecentQuestions(user);
            rpf.Show();
            this.Close();
        }
    }
}
