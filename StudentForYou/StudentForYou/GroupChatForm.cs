using System;
using System.Windows.Forms;
using StudentForYouGroupChat;
using System.Diagnostics;
using StudentForYou.DB;

namespace StudentForYou
{
    public partial class GroupChatForm : Form
    {
        GroupChat gchat;
        private Form prevform;
        Process proc; //If we wanted to close the server, we could use this.
        ProfileDB db = new ProfileDB();
        public GroupChatForm(Form prevForm, int id, int port, Process proc)
        {
            InitializeComponent();
            this.prevform = prevForm;
            this.proc = proc;
            gchat = new GroupChat(db.GetUser(id).username, port);
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
            prevform.Show();
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
