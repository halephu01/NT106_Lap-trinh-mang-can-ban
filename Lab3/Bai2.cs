using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace Lab3
{
    public partial class Bai2 : Form
    {
        IPEndPoint IP;
        Socket server;
        public Bai2()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btListen_Click(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            Connect(GetServer());
            MessageBox.Show("Listening at 127.0.0.1:1234", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMessage("Telnet running on 127.0.0.1:1234");
            btListen.Enabled = false;
        }

        void Receive(object obj)
        {
            int bytesReceived = 0;
            Socket client = obj as Socket;
            while (true)
            {
                if (!client.Connected)
                    break;
                string message = "";
                byte[] data = new byte[1024 * 8000];
                do
                {
                    bytesReceived = client.Receive(data);
                    message += Encoding.ASCII.GetString(data, 0, bytesReceived);
                } while (bytesReceived > 0 && message[message.Length - 1] != '\n');
                if (message == "")
                    break;
                AddMessage(message);
            }
        }

        void AddMessage(string message)
        {
            richTextBox1.Text += message;
        }

        private Socket GetServer()
        {
            return server;
        }

        void Connect(Socket server)
        {
            int bytesReceived = 0;
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                while (true)
                {
                    server.Listen(100);
                    Socket client = server.Accept();
                    byte[] dt = new byte[1024 * 8000];
                    if (!client.Connected)
                        break;
                    string message = "";
                    do
                    {
                        bytesReceived = client.Receive(dt);
                        message += Encoding.ASCII.GetString(dt, 0, bytesReceived);
                    } while (bytesReceived > 0 && message[message.Length - 1] != '\n');
                    if (message == "")
                        break;
                    AddMessage(message);
                    Thread receive = new Thread(Receive);
                    receive.IsBackground = true;
                    receive.Start(client);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }
    }
}
    