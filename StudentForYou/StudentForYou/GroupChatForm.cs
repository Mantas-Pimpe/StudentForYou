using System;
using System.Windows.Forms;
using StudentForYouGroupChat;
using System.Threading;

namespace StudentForYou
{
    public partial class GroupChatForm : Form
    {
        GroupChat gchat;
        private Form prevform;
        System.Diagnostics.Process proc;
        public GroupChatForm(Form prevForm, string username, int port, System.Diagnostics.Process proc)
        {
            InitializeComponent();
            this.prevform = prevForm;
            this.proc = proc;
            gchat = new GroupChat(username, port);
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
           /* proc.CloseMainWindow();
            proc.Close();*/
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
