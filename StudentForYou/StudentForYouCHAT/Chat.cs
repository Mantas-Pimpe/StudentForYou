using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace StudentForYou.Chat
{
    class Chat
    {
        Socket sck;
        EndPoint epLocal, epRemote;
        public Start()
        {
            Socket sck;
            EndPoint epLocal, epRemote;
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
            textLocalIp.Text = GetLocalIP();
            textFriendsIp.Text = GetLocalIP();
        }
    }
}
