using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace StudentForYouChat
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
                    var eEncoding = new ASCIIEncoding();
                    var receivedMessage = eEncoding.GetString(receivedData);
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

        public void Start(string friendsIp, string localIp, string friendsPort = "1", string localPort = "1")
        {
            try
            {
                // binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(localIp), Convert.ToInt32(localPort));
                sck.Bind(epLocal);
                // connect to remote IP and port
                epRemote = new IPEndPoint(IPAddress.Parse(friendsIp), Convert.ToInt32(friendsPort));
                sck.Connect(epRemote);
                // starts to listen to an specific port
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new
                AsyncCallback(MessageCallBack), buffer);
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
                var enc = new ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(message);
                // sending the message
                sck.Send(msg);
                MyEvent("You: " + message);
            }
            catch (Exception ex)
            {
                MyEvent(ex.ToString());
            }
        }

    }
}
