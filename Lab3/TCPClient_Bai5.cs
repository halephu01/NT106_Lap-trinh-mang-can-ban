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
    public partial class TCPClient_Bai5 : Form
    {
        public TCPClient_Bai5()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        IPEndPoint IP;
        Socket client;

        class ClientInfo
        {
            public string Name { get; set; }
            public string IpAddress { get; set; }
        }

        List<ClientInfo> clientsConnect = new List<ClientInfo>();

        void Connect()
        {
            IP = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4554);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            if (tbName.Text == string.Empty)
            {
                MessageBox.Show("Không thể kết nối tới server vì chưa nhập username", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    client.Connect(IP);
                    MessageBox.Show("Tạo kết nối tới server thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btSend.Enabled = true;
                    client.Send(Serialize(tbName.Text + " vừa tham gia."));
                }
                catch
                {
                    MessageBox.Show("Không thể kết nối tới server", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();
        }

        void Send()
        {
            if (tbMessage.Text != string.Empty)
            {
                client.Send(Serialize(tbName.Text + ": " + tbMessage.Text + "\n"));
                lsvMessage.Items.Add(tbName.Text + ": " + tbMessage.Text);
            }

            tbMessage.Clear();
        }

        void Receive()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 8000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    lsvMessage.Items.Add (message);
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
                client.Send(Serialize(tbName.Text + " đã thoát."));
                client.Shutdown(SocketShutdown.Both);
                MessageBox.Show("Ngắt kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btSend.Enabled = false;

            }
        }

        private void UpdateConnectedClientsListBox()
        {
            if (lsvOnline.InvokeRequired)
            {
                lsvOnline.Invoke(new Action(UpdateConnectedClientsListBox));
            }
            else
            {
                lsvOnline.Items.Clear();
                //lsvOnline.Items.AddRange(connectedClients.ToArray());
            }
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            Disconnect();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void TCPClient_Bai5_Load(object sender, EventArgs e)
        {

        }
    }
}
