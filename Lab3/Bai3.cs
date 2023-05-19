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

namespace Lab3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btTCP_Server_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPServer_Bai3 sv = new TCPServer_Bai3();
                sv.ShowDialog();
            });
            thread.Start();
            btTCP_Server.Enabled = false;
        }

        private void btTCP_Client_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPClient_Bai3 cl = new TCPClient_Bai3();
                cl.ShowDialog();
            });
            thread.Start();
            btTCP_Client.Enabled = false;
        }
    }
}
