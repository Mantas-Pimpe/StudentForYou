﻿using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using StundentForYouChat;

namespace StudentForYou
{
    public partial class ChatForm : Form
    {
        Chat talk;

        public ChatForm()
        {
            InitializeComponent();
            talk = new Chat();
            textLocalIp.Text = talk.GetLocalIP();
            textFriendsIp.Text = talk.GetLocalIP();
            talk.MyEvent += new Chat.MyDel(PostMessage);
        }
        public void PostMessage(string message)
        {
            if (listMessage.InvokeRequired)
                listMessage.Invoke(new MethodInvoker(delegate { listMessage.Text = listMessage.Text + Environment.NewLine + message; }));
            else
                listMessage.Text = listMessage.Text + Environment.NewLine + message;
        }
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupChat_Load(object sender, EventArgs e)
        {


        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            talk.Start(textLocalIp.Text, textLocalPort.Text, textFriendsIp.Text, textFriendsPort.Text);
            buttonSend.Enabled = true;
            buttonStart.Text = "Connected";
            buttonStart.Enabled = false;
            textMessage.Focus();
        }

        private void TextLocalIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            if (textMessage.Text != "")
            {
                talk.Send(textMessage.Text);
            }
            textMessage.Clear();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            //RecentPostsForm rpf = new RecentPostsForm();
            //rpf.Show();
        }

        private void TextFriendsIp_TextChanged(object sender, EventArgs e)
        {

        }
        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ListMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}