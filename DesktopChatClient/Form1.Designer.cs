namespace DesktopChatClient
{
    partial class Form1
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
            this.listChat = new System.Windows.Forms.ListBox();
            this.textMessege = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.ipTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listChat
            // 
            this.listChat.FormattingEnabled = true;
            this.listChat.Location = new System.Drawing.Point(12, 43);
            this.listChat.Name = "listChat";
            this.listChat.Size = new System.Drawing.Size(384, 199);
            this.listChat.TabIndex = 0;
            // 
            // textMessege
            // 
            this.textMessege.Location = new System.Drawing.Point(12, 248);
            this.textMessege.Name = "textMessege";
            this.textMessege.Size = new System.Drawing.Size(197, 20);
            this.textMessege.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(215, 246);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 25);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(107, 14);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(102, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "CONNECT";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ipTB
            // 
            this.ipTB.Location = new System.Drawing.Point(306, 251);
            this.ipTB.Name = "ipTB";
            this.ipTB.Size = new System.Drawing.Size(90, 20);
            this.ipTB.TabIndex = 4;
            this.ipTB.Text = "localhost:8080";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 286);
            this.Controls.Add(this.ipTB);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textMessege);
            this.Controls.Add(this.listChat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listChat;
        private System.Windows.Forms.TextBox textMessege;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox ipTB;
    }
}

