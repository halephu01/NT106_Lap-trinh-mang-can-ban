using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class TCPClient_Bai4 : Form
    {
        IPEndPoint IP;
        Socket client;

        public TCPClient_Bai4()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls=false;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void Connect()
        {
            

            try
            {
                IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5555);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(IP);
                MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Send(Serialize("Connection access from 127.0.0.1: 50443\n"));
                btSend.Enabled = true;
                btDisconnect.Enabled = true;
                btConnect.Enabled = false;
            }
            catch
            {
                IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 5556);
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(IP);
                MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Send(Serialize("Connection access from 127.0.0.1: 50443\n"));
                btSend.Enabled = true;
                btDisconnect.Enabled = true;
                btConnect.Enabled = false;
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send()
        {
            if (tbMessage.Text != string.Empty)
            {
                client.Send(Serialize("From client: " + tbMessage.Text + "\n"));
            }
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 8080];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                }
            }
            catch
            {
                Close();
            }
        }


        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        void Disconnect()
        {
            if (client != null && client.Connected)
            {
                MessageBox.Show("Ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Send(Serialize("Disconnection from 127.0.0.1: 50443\n"));
                btSend.Enabled = false;
                btConnect.Enabled = true;
                btDisconnect.Enabled = false;
            }
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void TCPClient_Bai4_Load(object sender, EventArgs e)
        {

        }

        private void txtLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
