using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace StudentForYouChat
{
    class Chat
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        string message;
        public Chat()
        {
            Socket sck;
            EndPoint epLocal, epRemote;
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            /*textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();*/
        }
        public string GetLocalIP()
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

        public void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    //listMessage.Items.Add("StuddyBuddy: " + receivedMessage);
                    //return "StuddyBuddy: " + receivedMessage;
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                //return e.ToString();
            }
        }

        public void Start(string textLocalIp, string textLocalPort, string textFriendsIp, string textFriendsPort)
        {
            try
            {
                // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textLocalIp), Convert.ToInt32(textLocalPort));
                sck.Bind(epLocal);
                // connect to remote IP and port
                epRemote = new IPEndPoint(IPAddress.Parse(textFriendsIp), Convert.ToInt32(textFriendsPort));
                sck.Connect(epRemote);
                // starts to listen to an specific port
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                AsyncCallback(MessageCallBack), buffer);
                // release button to send message

                /*buttonSend.Enabled = true;
                buttonStart.Text = "Connected";
                buttonStart.Enabled = false;
                textMessage.Focus();*/
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //return ex.ToString();
            }
        }
        public string Send(string textMessage)
        {
            try
            {
                if (textMessage != "")
                {
                    // converts from string to byte[]
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(textMessage);
                    // sending the message
                    sck.Send(msg);
                    // add to listbox
                    //listMessage.Items.Add("You: " + textMessage);
                    return "You: " + textMessage;
                    // clear txtMessage
                    //textMessage.Clear();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                return ex.ToString();
            }
            return null;
        }
    }
}
