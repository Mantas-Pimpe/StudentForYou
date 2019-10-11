using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                AddNewButton(likes, views, answers, question);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Loadbtn_Click(object sender, EventArgs e)
        {

        }

        public System.Windows.Forms.Button AddNewButton(string likes, string views, string answers, string question)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Top = A * 40;
            btn.Width = 910;
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Left = 15;
            btn.Text = "Like: " + likes + " Views: " + views + " Answers: " + answers + " ' " + question + " ' ";
            btn.Click += new EventHandler(btn_Click);
            A += 1;
            return btn;
        }

        void btn_Click(object sender, EventArgs e)
        {
          
        }

        private void newpostbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            NewPostForm newForm = new NewPostForm();
            newForm.Show();
        }

        private void coursesbtn_Click(object sender, EventArgs e)
        {
            form1 subjects = new form1();
            subjects.Show();
        }

        private void coursebtn_Click(object sender, EventArgs e)
        {
            form1 courses = new form1();
            this.Hide();
            courses.Show();
        }

        private void profilebtn_Click(object sender, EventArgs e)
        {
            String Username = "Jeff";
            UserProfile Profile = new UserProfile(Username);
            this.Hide();
            Profile.Show();
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
