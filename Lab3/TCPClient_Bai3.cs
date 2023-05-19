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
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Lab3
{
    public partial class TCPClient_Bai3 : Form
    {
        public TCPClient_Bai3()
        {
            InitializeComponent();
            btSend.Enabled = false;
            btDisconnect.Enabled = false;
        }
        IPEndPoint IP;
        Socket client; 
        
        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 1234);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                client.Connect(IP);
                MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Send(Serialize("Connection access from 127.0.0.1: 50443\n"));
                btSend.Enabled = true;
                btDisconnect.Enabled = true;
                btConnect.Enabled = false;              
            }
            catch
            {
                MessageBox.Show("Không thể kết nối tới Server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send()
        {
            if (rtbMessageClient.Text != string.Empty)
            {
                client.Send(Serialize("From client: " + rtbMessageClient.Text + "\n"));
            }
        }
        
        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data= new byte[1024 * 8080];
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

        private void btConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }
    }
}
