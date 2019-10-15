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
    public partial class RecentPostsForm : Form
    {
        int A = 1;
        public RecentPostsForm()
        {
            InitializeComponent();
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
            btn.Width = 1120;
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
                string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
                string[] line = lines[placeToReplace].Split(',');
                line[1] = views;
                string newLine = line[0] + "," + line[1] + "," + line[2] + "," + line[3];
                lines[placeToReplace] = newLine;
                StreamWriter writeText = new StreamWriter(@"..\Debug\Resources\recentquestions.txt");

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
            this.Close();
            NewPostForm newForm = new NewPostForm();
            newForm.Show();
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

        void button_click (object sender, EventArgs e, string question)
        {
            Button btn = sender as Button;
            SelectedQuestionForm QuestionForm = new SelectedQuestionForm(question);
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
