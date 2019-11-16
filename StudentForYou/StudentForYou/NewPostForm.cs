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
        int id;
        public NewPostForm(List<QuestionDetails> questionList, int id)
        {
            InitializeComponent();
            this.id = id;
            questionBox.Text = "Enter your question";
            SaveBtn.Click += delegate (Object sender, EventArgs e)
            {
                SaveBtn_Click(sender, e, questionList);
            };
        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e, List<QuestionDetails> questionList)
        {
            var db = new QuestionsDB();
            db.InsertIntoQuestions(qns_name: questiontxt.Text, qns_text: questiontxt.Text, qns_creation_date: DateTime.Now, id);

            var rpf = new RecentQuestions(id);
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
            var rpf = new RecentQuestions(id);
            rpf.Show();
            this.Close();
        }
    }
}
