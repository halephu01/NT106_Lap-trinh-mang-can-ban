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

namespace Lab3
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btTCP_Client_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPClient_Bai5 cl = new TCPClient_Bai5();
                cl.ShowDialog();
            });
            thread.Start();
        }

        private void btTCP_Server_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPServer_Bai5 sv = new TCPServer_Bai5();
                sv.ShowDialog();
            });
            thread.Start();
            btTCP_Server.Enabled = false;
        }
    }
}
