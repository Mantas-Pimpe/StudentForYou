using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using StudentForYouGroupChat;

namespace StudentForYou
{
    public partial class GroupChatForm : Form
    {
        GroupChat gchat;
        //private Form prevform;

        private string username = string.Empty;
        public GroupChatForm(/*Form prevForm, */string username)
        {
            InitializeComponent();
            //this.prevform = prevForm;
            this.username = username;
            gchat = new GroupChat(this.username);
            gchat.Start();
            Thread ctThread = new Thread(postMsg);
            ctThread.Start();

        }

        private void GroupChat_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void postMsg()
        {
            while (true)
            {
                listMessage.Text = gchat.getMessage();
            }
        }
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            gchat.Send(textMessage.Text);
            textMessage.Clear();
        }
        
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            var rpf = new RecentQuestions(username);
            rpf.Show();
            //prevform.Show();
            this.Close();
        }

        private void ListMessage_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
