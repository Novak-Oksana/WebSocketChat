using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopChatClient
{
    public partial class Form1 : Form
    {
        private ClientWebSocket client;

        public Form1()
        {
            InitializeComponent();

        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = Encoding.UTF8.GetBytes(textMessege.Text);
                await client.SendAsync(new ArraySegment<byte>(buffer), WebSocketMessageType.Text, false, CancellationToken.None);
                listChat.Items.Add("You: " + textMessege.Text);
            }
            catch
            {
                listChat.Items.Add("Cannot connect to server!");
            }
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (client == null)
                {
                    client = new ClientWebSocket();
                    await client.ConnectAsync(new Uri("ws://" + ipTB.Text), CancellationToken.None);
                    listChat.Items.Add("You've connected to the server!");
                    Receiver();
                }
            }
            catch (Exception ex)
            {
                listChat.Items.Add("Cannot connect to server!");
            }
        }

        private async void Receiver()
        {
            while (client.State == WebSocketState.Open)
            {
                byte[] buffer = new byte[1024];
                var result = await client.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None);
                listChat.Items.Add("Server: " + Encoding.UTF8.GetString(buffer).TrimEnd('\0'));
            }
        }
    }
}
