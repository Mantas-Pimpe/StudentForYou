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

namespace StudentForYou
{
    public partial class RecentQuestions : Form
    {
        int A = 1;
        private string username = string.Empty;
        public RecentQuestions(string username)
        {
            InitializeComponent();
            this.username = username;
            string likes, views, answers, question;
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            //Console.WriteLine(lines.Length);
            for (int i = 0; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(',');
                likes = line[0];
                views = line[1];
                answers = line[2];
                question = line[3];
                flowLayoutPanel1.Controls.Add(AddNewButton(likes, views, answers, question, i));

            }
        }



        public System.Windows.Forms.Button AddNewButton(string likes, string views, string answers, string question, int placeToReplace)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = A * 40;
            btn.Width = 840;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = "Like: " + likes + " Views: " + views + " Answers: " + answers + " ' " + question + " ' ";
            A += 1;
            btn.Click += delegate (object sender, EventArgs e)
            {
                button_click(sender, e, question);
                int count = Int32.Parse(views);
                count++;
                views = count.ToString();
                string[] lines = File.ReadAllLines(@"..\Debug\recentquestions.txt");
                string[] line = lines[placeToReplace].Split(',');
                line[1] = views;
                string newLine = line[0] + "," + line[1] + "," + line[2] + "," + line[3];
                lines[placeToReplace] = newLine;
                StreamWriter writeText = new StreamWriter(@"recentquestions.txt");

                for (int currentLine = 0; currentLine < lines.Length; ++currentLine)
                {
                    if (currentLine == placeToReplace)
                    {
                        writeText.WriteLine(lines[placeToReplace]);
                    }
                    else
                    {
                        writeText.WriteLine(lines[currentLine]);
                    }
                }
                writeText.Close();
                this.Close();
            };
            return btn;
        }


        private void newpostbtn_Click(object sender, EventArgs e)
        {
            
            var newForm = new NewPostForm(username);
            newForm.Show();
            this.Close();
        }

        private void coursesbtn_Click(object sender, EventArgs e)
        {
            var subjects = new form1(username);
            subjects.Show();
            this.Close();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        { 
            var courses = new RecentQuestions(username);
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
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.WrapContents = false;
        }

        void button_click (object sender, EventArgs e, string question)
        {
            var btn = sender as Button;
            var QuestionForm = new SelectedQuestionForm(question,username);
            this.Close();
            QuestionForm.Show();
        }

        private void Chat_Click(object sender, EventArgs e)
        {
            var chat = new Chat(this);
            this.Hide();
            chat.Show();
        }

        private void GroupChat_Click(object sender, EventArgs e)
        {
            var gchat = new GroupChat(this,username);
            this.Hide();
            gchat.Show();
        }

        private void RecentPostsForm_Load(object sender, EventArgs e)
        {
        }

        private void RecentQuestions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.OfType<Form>().Count() == 1)
                Application.Exit();
        }
    }
}
