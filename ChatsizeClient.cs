﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatSizeClient;

namespace ChatSizeClient
{
    public partial class ChatSizeClientMain : Form
    {
        string RealtimeChatAdminCodeSizeStatus = null;
        public static ChatSizeClientMain chatSizeClientMain;
        public static MainMenu UpdateRealtimechat;


        string sendtextShowStatus = null;
        public static MainMenu Cheackstatusserver;
        public ChatSizeClientMain()
        {
            RealtimeChatAdminCodeSizeStatus = "close";
            sendtextShowStatus = "close";
            chatSizeClientMain = this;
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        public static void beepSound()
        {
            Console.Beep();
        }

        public static void MenuOpenChatSound() //เปิดเสียง ComputerData
        {
            System.IO.Stream str = ChatSizeClient2.Properties.Resources.ComputerData;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        public static void MenuOpenChatSoundLoading()//เปิดเสียง Loading_Sound
        {
            System.IO.Stream str = ChatSizeClient2.Properties.Resources.Loading_Sound;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void MenuOpenChat()
        {
            while (Menuchat.Height <= 455)
            {
                Menuchat.Height += 1;
                Task.Delay(500);
            }
            Thread MOCS = new Thread(MenuOpenChatSound);
            MOCS.Start();
        }
        private void MenuCloseChat()
        {
            while (Menuchat.Height >= 60)
            {
                Menuchat.Height -= 1;
                Task.Delay(500);
            }
        }

        public string ChatSizeClientUpdateChatAdminCode;
        public static void UpdateRealtimechatClientSize(string RealtimeupdateClientSize)
        {
            while (true)
            {
                MessageBox.Show("Work!");
                string ChatSizeClientUpdateChatAdminCode = RealtimeupdateClientSize.ToString();
                ChatSizeClientMain.chatSizeClientMain.RealtimeChatAdminCodeSize.Text = ChatSizeClientUpdateChatAdminCode;
            }
        }

        //public static void UpdateRealtimechatClientSizeShow() //เปิดด้วย
        //{
        //    ChatSizeClientMain.chatSizeClientMain.RealtimeChatAdminCodeSize.Text = ChatSizeClientUpdateChatAdminCode.ToString;
        //}

        private void UpdateChatAdminCode_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                MessageBox.Show("Work!");
                RealtimeChatAdminCodeSize.Text = ChatSizeClientUpdateChatAdminCode;
                Console.WriteLine(ChatSizeClientUpdateChatAdminCode);
            }
        }

        //Client SIZE
        public static void UpdateRealtimeChat(string msg)
        {
            if (chatSizeClientMain != null)
                chatSizeClientMain.updateRealtimeChat(msg);
        }

        private delegate void ChatDelegate(string msg);
        private void updateRealtimeChat(string msg)
        {
            // If this returns true, it means it was called from an external thread.
            if (InvokeRequired)
            {
                // Create a delegate of this method and let the form run it.
                this.Invoke(new ChatDelegate(updateRealtimeChat), new object[] { msg });
                return; // Important
            }

            // Set textBox

            RealtimeChatAdminCodeSize.Text += msg;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (sendtextShowStatus == "close")
            {
                Thread MOCS = new Thread(MenuOpenChatSoundLoading);
                MOCS.Start();
                MenuOpenChat();
                PermissionText.Visible = true;
                Task.Delay(1500);
                AdminCodeChatSize.Visible = true;
                Task.Delay(1500);
                ChatsizePicture.Visible = true;
                sendtextShowStatus = "open";
                Thread MOCS2 = new Thread(MenuOpenChatSound);
                MOCS2.Start();
                SendText.Visible = true;
                Task.Delay(1500);
                SendTextButton.Visible = true;
            }
            else if (sendtextShowStatus == "open")
            {
                Thread MOCS = new Thread(MenuOpenChatSoundLoading);
                MOCS.Start();
                AdminCodeChatSize.Visible = false;
                Task.Delay(1500);
                ChatsizePicture.Visible = false;
                Task.Delay(1500);
                SendText.Visible = false;
                Task.Delay(1500);
                SendTextButton.Visible = false;
                Task.Delay(1500);
                PermissionText.Visible = false;
                MenuCloseChat();
                Thread MOCS2 = new Thread(MenuOpenChatSound);
                MOCS2.Start();
                sendtextShowStatus = "close";
            }

        }

        private void SendTextButton_Click_1(object sender, EventArgs e)
        {
            //byte[] buffer = Encoding.ASCII.GetBytes(PermissionText + usernamesend + " : " + bytesToSend);
            Console.Beep();
            Client.sendData(" [ " + PermissionText.Text + " ] ", USERNAME.Text + " : ", SendText.Text);
            Console.Beep();
            RealtimeChatAdminCodeSize.Text += SendText.Text + "\r\n";
        }

        private void AdminCodeChatSize_Click(object sender, EventArgs e)
        {
            if (RealtimeChatAdminCodeSizeStatus == "close")
            {
                RealtimeChatAdminCodeSize.Visible = true;
                RealtimeChatAdminCodeSizeStatus = "open";
                Thread BeepSound = new Thread(beepSound);
                SendTextButton.Visible = true;
            }
            else
            {
                RealtimeChatAdminCodeSize.Visible = false;
                RealtimeChatAdminCodeSizeStatus = "close";
                Thread BeepSound = new Thread(beepSound);
                SendTextButton.Visible = true;
            }
        }

        private void ChatSizeClientMain_Load(object sender, EventArgs e)
        {
            Thread MOCS = new Thread(MenuOpenChatSound);
            MOCS.Start();
        }

        private void SendText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}