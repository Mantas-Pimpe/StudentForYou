using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForYou
{
    public partial class SelectedQuestionForm : Form
    {


        public SelectedQuestionForm(String question, String likes, String views, String answers, int placeToReplace)
        {
            InitializeComponent();
            AddNewLabel(question);
            AddNewButton(500, 530);
            AddLikeButton(870, 5, question, likes, views, answers, placeToReplace);
            button1.Click += delegate (Object sender, EventArgs e)
            {
                button1_Click(sender, e, likes, views, answers, question, placeToReplace);
            };
            RefreshTextBox(placeToReplace);
        }

        void RefreshTextBox(int placeToReplace)
        {
            txtAnswers.Text = "";
            Random rnd = new Random();
            string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
            string[] line = lines[placeToReplace].Split('`');
            string[] answer = line[4].Split('^');
            for (int i = 1; i < answer.Length; i++)
            {
                int randomNumber = rnd.Next(555, 987587);
                txtAnswers.AppendText("User" + randomNumber + ": " + answer[i]);
                txtAnswers.AppendText(Environment.NewLine);
            }
        }

        public System.Windows.Forms.Label AddNewLabel(string question)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(label);
            label.Size = new System.Drawing.Size(850, 30);
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

        public System.Windows.Forms.Button AddLikeButton(int xPos, int yPos, String question, String likes, String views, String answers, int placeToReplace)
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
                int count = Int32.Parse(likes);
                count++;
                likes = count.ToString();
                string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
                string[] line = lines[placeToReplace].Split('`');
                line[0] = likes;
                string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`" + line[4];
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
            btn.Click += new EventHandler(this.button_click);
            return btn;
        }

        void button_click (object sender, EventArgs e)
        {
            Button btn = sender as Button;
            RecentPostsForm rpf = new RecentPostsForm();
            this.Close();
            rpf.Show();
        }
        private void SelectedQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e, String likes, String views, String answers, String question, int placeToReplace)
        {
            if (richTextBox1.Text != String.Empty)
            {
                int count = Int32.Parse(answers);
                count++;
                answers = count.ToString();
                string[] lines = File.ReadAllLines(@"..\Debug\Resources\recentquestions.txt");
                string[] line = lines[placeToReplace].Split('`');
                line[2] = answers;
                string newLine = line[0] + "`" + line[1] + "`" + line[2] + "`" + line[3] + "`"  + line[4] + "^" + richTextBox1.Text;
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
            }
            richTextBox1.Text = "";
            RefreshTextBox(placeToReplace);
        }

        private void txtAnswers_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
