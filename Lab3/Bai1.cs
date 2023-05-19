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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btUDPServer_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPServer_Bai1 sv = new UDPServer_Bai1();
                sv.ShowDialog();
            });
            thread.Start();
            btUDPServer.Enabled = false;
        }

        private void btUDPClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                UDPClient_Bai1 cl = new UDPClient_Bai1();
                cl.ShowDialog();
            });
            thread.Start();
            btUDPClient.Enabled = false;
        }
    }
}
