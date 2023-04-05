using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        public Lab1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            Bai2 bai2 = new Bai2();
            bai2.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            Bai3 bai3 = new Bai3();
            bai3.ShowDialog();
        }

        private void Bai3_1_Click(object sender, EventArgs e)
        {
            Bai3_1 bai3_1 = new Bai3_1();
            bai3_1.ShowDialog();
        }

        private void Bai4_Click(object sender, EventArgs e)
        {
            Bai4 bai4 = new Bai4();
            bai4.ShowDialog();
        }

        private void Bai5_Click(object sender, EventArgs e)
        {
            Bai5 bai5 = new Bai5();
            bai5.ShowDialog();
        }

        private void Bai7_Click(object sender, EventArgs e)
        {
            Bai7 bai7 = new Bai7();
            bai7.ShowDialog();
        }

        private void Bai8_Click(object sender, EventArgs e)
        {
            Bai8 bai8 = new Bai8();
            bai8.ShowDialog();
        }
    }
}
