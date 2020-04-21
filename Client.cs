using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatSizeClient
{
    public static class Client
    {
        public static NetworkStream ns;
        public static TcpClient client;
        public static ChatSizeClientMain UpdateRealtimechat;
        public static int ConnectedtoserverText;
        public static ChatSizeClientMain Cheackstatusserver;
        public static Thread thread;
        public static ChatSizeClientMain admin;
        public static IPAddress ip;
        public static int port;


        public static void Start()
        {

        }
        public static void sendData(string PermissionText, String usernamesend, String bytesToSend)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(PermissionText + usernamesend + " : " + bytesToSend);
            ns.Write(buffer, 0, buffer.Length);
        }

        public static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
        }
    }
}
