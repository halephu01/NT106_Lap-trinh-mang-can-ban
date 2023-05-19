using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Lab3
{
    public partial class UDPServer_Bai1 : Form
    {
        Socket socket;
        byte[] buffer = new byte[1024];
        EndPoint endpoint = new IPEndPoint(IPAddress.Any, 0);

        public UDPServer_Bai1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
    
        private void btListen_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(tbPort.Text) < 1024 || Int32.Parse(tbPort.Text) > 65535)
                MessageBox.Show("Hãy nhập một Port trong khoảng (1024-65535)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Any, Int32.Parse(tbPort.Text));
                socket.Bind(ipEndPoint);
                Thread listen = new Thread(Receive);
                listen.IsBackground = true;
                listen.Start();
            }    
        }

        void Receive()
        {
            while (true)
            {
                string receive_data;
                socket.ReceiveFrom(buffer, 0, 1024, SocketFlags.None, ref endpoint);
                receive_data = Encoding.UTF8.GetString(buffer);
                rtbMessageServer.Text = receive_data;
            }
        }
    }
}
