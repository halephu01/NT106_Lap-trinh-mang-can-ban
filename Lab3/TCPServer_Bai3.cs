using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Lab3
{
    public partial class TCPServer_Bai3 : Form
    {
        IPEndPoint IP;
        Socket server;

        public TCPServer_Bai3()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            while (true)
            {
                byte[] data = new byte[1024 * 8080];
                client.Receive(data);
                string message = (string)Deserialize(data);
                AddMessage(message);
            }
        }

        void AddMessage(string message)
        {
            rtbMessageServer.Text += message;
        }
        //Tạo một đối tượng IPEndPoint để định nghĩa địa chỉ IP và port của Server
        //liên kết socket với địa chỉ IP
        //Kết nối với server

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
              {
                  while (true)
                  {
                      server.Listen(100);
                      Socket client = server.Accept();
                      byte[] dt = new byte[1024 * 8080];
                      client.Receive(dt);
                      string message = (string)Deserialize(dt);
                      client.Send(Serialize(message));
                      AddMessage(message);
                      Thread receive = new Thread(Receive);
                      receive.IsBackground = true;
                      receive.Start(client);
                  }
              });
            Listen.IsBackground = true;
            Listen.Start();
        }

        //Hàm phân mảnh dữ liệu
        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        // Hàm gom mảnh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(stream);
        }

        private void btListen_Click(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMessage("Get started!\n");
            Connect();
            btListen.Enabled = false;
        }
    }
}
