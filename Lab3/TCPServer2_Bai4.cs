﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCPServer2_Bai4 : Form
    {
        IPEndPoint IP;
        Socket server;

        public TCPServer2_Bai4()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void TCP_Server2_Load(object sender, EventArgs e)
        {

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
            lsvMessage.Items.Add(message);
        }

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5556);
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

        private void btListen2_Click(object sender, EventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint IPendpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5556);
            MessageBox.Show("Tạo thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddMessage("Get started!\n");
            Connect();
        }

        private void TCPServer2_Bai4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
