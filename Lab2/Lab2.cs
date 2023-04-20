using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Lab2 : Form
    {
        public Lab2()
        {
            InitializeComponent();
        }

        private void btBai1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void btBai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void btBai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.ShowDialog();
        }

        private void btBai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void btBai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }

        private void btBai6_Click(object sender, EventArgs e)
        {
            Bai6 bai6 = new Bai6();
            bai6.ShowDialog();
        }
    }
}
