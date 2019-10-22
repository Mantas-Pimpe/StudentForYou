using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;

namespace StundentForYouChat
{
    public class Chat
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public delegate void MyDel(string message);
        public event MyDel MyEvent;
        public Chat()
        {
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
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
        private void MessageCallBack(IAsyncResult aResult)
        {
            try
            {
                var size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size > 0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    var receivedMessage = eEncoding.GetString(receivedData);
                    //listMessage.Items.Add("StuddyBuddy: " + receivedMessage);
                    MyEvent("StuddyBuddy: " + receivedMessage);
                }
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception e)
            {
                MyEvent(e.ToString());
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
            }
            catch (Exception ex)
            { 
                MyEvent(ex.ToString());
            }
        }

        public void Send(string message)
        {
            try
            {
                    // converts from string to byte[]
                    System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                    byte[] msg = new byte[1500];
                    msg = enc.GetBytes(message);
                    // sending the message
                    sck.Send(msg);
                    // add to listbox
                    //listMessage.Items.Add("You: " + textMessage.Text);
                    MyEvent("You: " + message);
                     // clear txtMessage
            }
            catch (Exception ex)
            {
                MyEvent(ex.ToString());
            }
        }

    }
}
