namespace ChatSizeClient
{
    partial class ChatSizeClientMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatSizeClientMain));
            this.SendTextButton = new System.Windows.Forms.Button();
            this.SendText = new System.Windows.Forms.TextBox();
            this.RealtimeChatAdminCodeSize = new System.Windows.Forms.TextBox();
            this.AdminCodeChatSize = new System.Windows.Forms.Button();
            this.Menuchat = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.USERNAME = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.UpdateChatAdminCode = new System.ComponentModel.BackgroundWorker();
            this.PermissionText = new System.Windows.Forms.TextBox();
            this.ChatsizePicture = new System.Windows.Forms.PictureBox();
            this.Menuchat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatsizePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SendTextButton
            // 
            this.SendTextButton.BackColor = System.Drawing.Color.Black;
            this.SendTextButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.SendTextButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SendTextButton.Location = new System.Drawing.Point(1013, 576);
            this.SendTextButton.Name = "SendTextButton";
            this.SendTextButton.Size = new System.Drawing.Size(108, 53);
            this.SendTextButton.TabIndex = 11;
            this.SendTextButton.Text = "SEND";
            this.SendTextButton.UseVisualStyleBackColor = false;
            this.SendTextButton.Visible = false;
            this.SendTextButton.Click += new System.EventHandler(this.SendTextButton_Click_1);
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.SystemColors.InfoText;
            this.SendText.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendText.ForeColor = System.Drawing.SystemColors.Info;
            this.SendText.Location = new System.Drawing.Point(341, 576);
            this.SendText.Multiline = true;
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(666, 53);
            this.SendText.TabIndex = 10;
            this.SendText.Visible = false;
            this.SendText.TextChanged += new System.EventHandler(this.SendText_TextChanged);
            // 
            // RealtimeChatAdminCodeSize
            // 
            this.RealtimeChatAdminCodeSize.BackColor = System.Drawing.Color.Black;
            this.RealtimeChatAdminCodeSize.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.RealtimeChatAdminCodeSize.ForeColor = System.Drawing.Color.White;
            this.RealtimeChatAdminCodeSize.Location = new System.Drawing.Point(341, 19);
            this.RealtimeChatAdminCodeSize.Multiline = true;
            this.RealtimeChatAdminCodeSize.Name = "RealtimeChatAdminCodeSize";
            this.RealtimeChatAdminCodeSize.Size = new System.Drawing.Size(780, 552);
            this.RealtimeChatAdminCodeSize.TabIndex = 9;
            this.RealtimeChatAdminCodeSize.Visible = false;
            // 
            // AdminCodeChatSize
            // 
            this.AdminCodeChatSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.AdminCodeChatSize.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.AdminCodeChatSize.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdminCodeChatSize.Location = new System.Drawing.Point(9, 67);
            this.AdminCodeChatSize.Name = "AdminCodeChatSize";
            this.AdminCodeChatSize.Size = new System.Drawing.Size(316, 66);
            this.AdminCodeChatSize.TabIndex = 5;
            this.AdminCodeChatSize.Text = "AdminCode";
            this.AdminCodeChatSize.UseVisualStyleBackColor = false;
            this.AdminCodeChatSize.Visible = false;
            this.AdminCodeChatSize.Click += new System.EventHandler(this.AdminCodeChatSize_Click);
            // 
            // Menuchat
            // 
            this.Menuchat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.Menuchat.Controls.Add(this.pictureBox1);
            this.Menuchat.Controls.Add(this.USERNAME);
            this.Menuchat.Controls.Add(this.button8);
            this.Menuchat.Controls.Add(this.button7);
            this.Menuchat.Controls.Add(this.button6);
            this.Menuchat.Controls.Add(this.button5);
            this.Menuchat.Controls.Add(this.button4);
            this.Menuchat.Controls.Add(this.button3);
            this.Menuchat.Controls.Add(this.AdminCodeChatSize);
            this.Menuchat.Location = new System.Drawing.Point(5, 6);
            this.Menuchat.Name = "Menuchat";
            this.Menuchat.Size = new System.Drawing.Size(330, 69);
            this.Menuchat.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // USERNAME
            // 
            this.USERNAME.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.USERNAME.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.USERNAME.ForeColor = System.Drawing.Color.Transparent;
            this.USERNAME.Location = new System.Drawing.Point(73, 12);
            this.USERNAME.Name = "USERNAME";
            this.USERNAME.Size = new System.Drawing.Size(252, 49);
            this.USERNAME.TabIndex = 6;
            this.USERNAME.Text = "YOURNAME";
            this.USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button8.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button8.Location = new System.Drawing.Point(9, 499);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(316, 66);
            this.button8.TabIndex = 5;
            this.button8.Text = "Client6";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button7.Location = new System.Drawing.Point(9, 427);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(316, 66);
            this.button7.TabIndex = 5;
            this.button7.Text = "Client5";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.Location = new System.Drawing.Point(9, 355);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(316, 66);
            this.button6.TabIndex = 5;
            this.button6.Text = "Client4";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button5.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.Location = new System.Drawing.Point(9, 283);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(316, 66);
            this.button5.TabIndex = 5;
            this.button5.Text = "Client3";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button4.Location = new System.Drawing.Point(9, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(316, 66);
            this.button4.TabIndex = 5;
            this.button4.Text = "Client2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(19)))), ((int)(((byte)(13)))));
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(9, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(316, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Client1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // PermissionText
            // 
            this.PermissionText.BackColor = System.Drawing.SystemColors.InfoText;
            this.PermissionText.Font = new System.Drawing.Font("Franklin Gothic Medium", 22.2F);
            this.PermissionText.ForeColor = System.Drawing.Color.White;
            this.PermissionText.Location = new System.Drawing.Point(19, 577);
            this.PermissionText.Multiline = true;
            this.PermissionText.Name = "PermissionText";
            this.PermissionText.Size = new System.Drawing.Size(311, 52);
            this.PermissionText.TabIndex = 14;
            this.PermissionText.Text = "Member";
            this.PermissionText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ChatsizePicture
            // 
            this.ChatsizePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChatsizePicture.Image = ((System.Drawing.Image)(resources.GetObject("ChatsizePicture.Image")));
            this.ChatsizePicture.Location = new System.Drawing.Point(341, 18);
            this.ChatsizePicture.Name = "ChatsizePicture";
            this.ChatsizePicture.Size = new System.Drawing.Size(780, 552);
            this.ChatsizePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ChatsizePicture.TabIndex = 13;
            this.ChatsizePicture.TabStop = false;
            this.ChatsizePicture.Visible = false;
            // 
            // ChatSizeClientMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1126, 635);
            this.Controls.Add(this.SendTextButton);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.RealtimeChatAdminCodeSize);
            this.Controls.Add(this.Menuchat);
            this.Controls.Add(this.ChatsizePicture);
            this.Controls.Add(this.PermissionText);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "ChatSizeClientMain";
            this.Text = "Chat Size Client";
            this.Load += new System.EventHandler(this.ChatSizeClientMain_Load);
            this.Menuchat.ResumeLayout(false);
            this.Menuchat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatsizePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendTextButton;
        private System.Windows.Forms.TextBox SendText;
        public System.Windows.Forms.TextBox RealtimeChatAdminCodeSize;
        private System.Windows.Forms.Button AdminCodeChatSize;
        private System.Windows.Forms.Panel Menuchat;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox USERNAME;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox ChatsizePicture;
        private System.ComponentModel.BackgroundWorker UpdateChatAdminCode;
        private System.Windows.Forms.TextBox PermissionText;
    }
}

