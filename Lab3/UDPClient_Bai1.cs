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

namespace Lab3
{
    public partial class UDPClient_Bai1 : Form
    {
        Socket socket;
        IPEndPoint endPoint;
        byte[] buffer = new byte[1024];
        public UDPClient_Bai1()
        {
            InitializeComponent();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(tbHost.Text, out ip))
            {
                MessageBox.Show("Hãy nhập một IP chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Int32.Parse(tbPort.Text) < 1024 || Int32.Parse(tbPort.Text) > 65535)
                    MessageBox.Show("Hãy nhập một Port trong khoảng (1024 - 65535)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                    string IP = tbHost.Text;
                    int port = Int32.Parse(tbPort.Text);
                    endPoint = new IPEndPoint(IPAddress.Parse(IP), port);
                    if (rtbMessageClient.Text != "")
                    {
                        byte[] data = Encoding.UTF8.GetBytes(tbHost.Text + ": " + rtbMessageClient);
                        socket.SendTo(data, endPoint);
                    }
                }
            }
        }
    }
}

