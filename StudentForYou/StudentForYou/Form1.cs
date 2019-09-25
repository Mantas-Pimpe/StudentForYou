using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
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
            string[] lines = File.ReadAllLines(@"C:\Users\Karolis\Desktop\StudentsForYou\StudentForYou\StudentForYou\RecentPosts.txt");
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
            btn.Top = A * 28;
            btn.Width = 570;
            
            btn.Left = 15;
            btn.Text = "Like: " + likes + " Views: " + views + " Answers: " + answers + " ' " + question + " ' ";
            btn.Click += new EventHandler(btn_Click);
            A += 1;
            return btn;
        }

        void btn_Click(object sender, EventArgs e)
        {
            /*RecentPostsForm newForm = new RecentPostsForm();
            this.Hide();
            newForm.Show();*/
        }

        private void newpostbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            NewPostForm newForm = new NewPostForm();
            newForm.Show();
        }
    }
}
