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
        public SelectedQuestionForm(String question, string username)
        {
            InitializeComponent();
            this.username = username;
            AddNewLabel(question);
            AddNewButton(450, 530, "Back");
            AddNewButton(400, 530, "Like");
        }

        public System.Windows.Forms.Label AddNewLabel(string question)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();
            this.Controls.Add(label);
            label.Size = new System.Drawing.Size(940, 30);
            label.Font = new Font("Arial", 16, FontStyle.Regular);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Text = question;
            return label;
        }

        public System.Windows.Forms.Button AddNewButton(int xPos, int yPos, string text)
        {
            System.Windows.Forms.Button btn = new System.Windows.Forms.Button();
            this.Controls.Add(btn);
            btn.Width = 60;
            btn.Location = new Point(xPos, yPos);
            btn.Height = 40;
            btn.TextAlign = ContentAlignment.MiddleCenter;
            btn.Text = text;
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
    }
}
