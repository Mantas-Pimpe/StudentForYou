using System;
using System.Windows.Forms;
using StudentForYouGroupChat;
using System.Threading;

namespace StudentForYou
{
    public partial class GroupChatForm : Form
    {
        GroupChat gchat;
        string username;
        //private Form prevform;
        public GroupChatForm(/*Form prevForm, */string username)
        {
            InitializeComponent();
            //this.prevform = prevForm;
            this.username = username;
            gchat = new GroupChat(this.username);
            gchat.MyEvent += new GroupChat.MyDel(PostMessage);
            gchat.Start();

        }

        public void PostMessage(string message)
        {
            if (listMessage.InvokeRequired)
                listMessage.Invoke(new MethodInvoker(delegate { listMessage.Text = listMessage.Text + message; }));
            else
                listMessage.Text = listMessage.Text + message;
        }
        private void GroupChat_Load(object sender, EventArgs e)
        {
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
