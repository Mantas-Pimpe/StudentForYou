using System;
using System.Net.Sockets;
using System.Threading;

namespace StudentForYouGroupChat
{

    public class GroupChat
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);

        string readData = null;
        string username;
        int port;

        public delegate void MyDel(string message);
        public event MyDel MyEvent;

        public GroupChat(string username, int port)
        {
            this.port = port;
            this.username = username;
        }

        public void Start()
        {
            readData = "Conected to Chat Server ...";
            MyEvent(readData);
            clientSocket.Connect("127.0.0.1", port);
            serverStream = clientSocket.GetStream();

            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(username + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
            var ctThread = new Thread(getMessage);
            ctThread.Start();
        }
        public void Send(string msg)
        {
            byte[] outStream = System.Text.Encoding.ASCII.GetBytes(msg + "$");
            serverStream.Write(outStream, 0, outStream.Length);
            serverStream.Flush();
        }
        public void getMessage()
        {
            while (true)
            {
                serverStream = clientSocket.GetStream();
                var buffSize = 0;
                byte[] inStream = new byte[clientSocket.ReceiveBufferSize];
                buffSize = clientSocket.ReceiveBufferSize;
                serverStream.Read(inStream, 0, buffSize);
                var returnData = System.Text.Encoding.ASCII.GetString(inStream);
                readData = "" + returnData;
                MyEvent(Environment.NewLine + " >> " + readData);
            }
        }

    }
}