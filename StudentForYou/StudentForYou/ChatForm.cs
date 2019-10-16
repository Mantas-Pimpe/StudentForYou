using System;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using StudentForYouChat;

namespace StudentForYou
{
    public partial class ChatForm : Form
    {

        Chat chat;
        public ChatForm()
        {
            InitializeComponent();
            chat = new Chat();
            textLocalIp.Text = chat.GetLocalIP();
            textFriendsIp.Text = chat.GetLocalIP();
        }
        public void setMessage(string message)
        {
            listMessage.Items.Add(message);
        }
       
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupChat_Load(object sender, EventArgs e)
        {


        }
        
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            chat.Start(textLocalIp.Text, textLocalPort.Text, textFriendsIp.Text, textFriendsPort.Text);
        }

        private void TextLocalIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            listMessage.Items.Add(chat.Send(textMessage.Text));
            textMessage.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            RecentPostsForm rpf = new RecentPostsForm();
            rpf.Show();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void TextFriendsIp_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
