using System;
using System.Net.Sockets;

namespace StudentForYouGroupChat
{
    public class GroupChat
    {
        System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        private string username = string.Empty;
        public GroupChat(string username)
        {
            this.username = username;
        }
        public void Start()
        {
            readData = "Conected to Chat Server ...";
            msg();
            clientSocket.Connect("127.0.0.1", 8888);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(username + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();

            /*Thread ctThread = new Thread(getMessage);
            ctThread.Start();*/
        }
        public void Send(string msg)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
        public string getMessage()
        {
                serverStream = clientSocket.GetStream();
                int buffSize = 0;
                byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                string returndata = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returndata;
                return msg();
        }
        public string msg()
        {
            /*if (this.InvokeRequired)
                this.Invoke(new MethodInvoker(msg));
            return "error";
            else*/
                return Environment.NewLine + " >> " + readData;
        }
    }
}
