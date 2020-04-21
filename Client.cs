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
            //*****
            Console.Beep();
            MessageBox.Show("1");
            ns = client.GetStream();
            MessageBox.Show("2");
            //*****
            MessageBox.Show("Chatsize Connected");

            Thread clientReceive = new Thread(o => ReceiveData((TcpClient)o));
            clientReceive.Start(client);
        }
        public static void sendData(string PermissionText, String USERNAME, String bytesToSend)
        {
            NetworkStream stream = client.GetStream();
            MessageBox.Show(bytesToSend + "Test");
            byte[] buffersend = Encoding.ASCII.GetBytes(PermissionText + USERNAME + " : " + bytesToSend);
            stream.Write(buffersend, 0, buffersend.Length);
        }

        public static void ReceiveData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
        }
    }
}
