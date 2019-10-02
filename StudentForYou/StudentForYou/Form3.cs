using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace StudentForYou
{
    public partial class Chat : Form
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Chat()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }
        private string GetLocalIP()
        {
            IPHostEntry host;
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return "127.0.0.1";
        }
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size>0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    listMessage.Items.Add("StuddyBuddy: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        private void TextMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void GroupChat_Load(object sender, EventArgs e)
        {


        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            try
            { 
                // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp.Text), Convert.ToInt32(textLocalPort.Text));
                sck.Bind(epLocal);
                // connect to remote IP and port
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp.Text), Convert.ToInt32(textFriendsPort.Text));
                sck.Connect(epRemote);
                // starts to listen to an specific port
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                AsyncCallback(MessageCallBack), buffer);
                // release button to send message
                buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TextLocalIp_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            try
            {
                if(textMessage.Text != "")
                {
                    // converts from string to byte[]
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(textMessage.Text);
                    // sending the message
                    sck.Send(msg);
                    // add to listbox
                    listMessage.Items.Add("You: " + textMessage.Text);
                    // clear txtMessage
                    textMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TextFriendsIp_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
