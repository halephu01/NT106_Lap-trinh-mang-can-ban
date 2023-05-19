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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btServer1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPServer1_Bai4 sv1 = new TCPServer1_Bai4();
                sv1.ShowDialog();
            });
            thread.Start();
            btServer1.Enabled = false;
        }

        private void btServer2_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPServer2_Bai4 sv2 = new TCPServer2_Bai4();
                sv2.ShowDialog();
            });
            thread.Start();
            btServer2.Enabled = false;
        }

        private void btClient_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                TCPClient_Bai4 cl = new TCPClient_Bai4();
                cl.ShowDialog();
            });
            thread.Start();
            btClient.Enabled = false;
        }
    }
}
