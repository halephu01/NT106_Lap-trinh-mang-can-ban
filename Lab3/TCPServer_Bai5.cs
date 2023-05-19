using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lab3
{
    public partial class TCPServer_Bai5 : Form
    {
        IPEndPoint IP;
        Socket server;
        List<Socket> clientList;
        IPAddress ip;

        public TCPServer_Bai5()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] dt = new byte[1024 * 8000];
                    client.Receive(dt);
                    string message = (string)Deserialize(dt);
                    foreach (Socket s in clientList)
                    {
                        if (s != null && s != client)                      
                            s.Send(Serialize(message));                       
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                clientList.Remove(client);
            }
        }

        void AddMessage(string message)
        {
            lsvMessage.Items.Add(message);
        }

        void Connect()
        {
            clientList = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4554);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            server.Bind(IP);
            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientList.Add(client);
                        byte[] data = new byte[1024 * 8000];
                        client.Receive(data);
                        string message = (string)Deserialize(data);
                        foreach (Socket s in clientList)
                        {
                            if (s != null && s != client)
                                s.Send(Serialize(message));
                        }
                        AddMessage(message);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4554);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                }
            });
            Listen.IsBackground = true;
            Listen.Start();
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        //Hàm gom mảnh
        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            return binaryFormatter.Deserialize(stream);
        }

        private void btListen_Click_1(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4554);
            Connect();
            MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMessage("Server running on 127.0.0.1:4554");
            btListen.Enabled = false;
        }
    }
}

