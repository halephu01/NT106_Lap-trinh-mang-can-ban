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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btSoThuNhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int a, b;
            if (!Int32.TryParse(tbSoThuNhat.Text.Trim(),out a) || !Int32.TryParse(tbSoThuHai.Text.Trim(),out b))
                MessageBox.Show("Vui lòng nhập số nguyên!");
            else
                tbTong.Text = (Int32.Parse(tbSoThuNhat.Text) + Int32.Parse(tbSoThuHai.Text)).ToString();
        }
    }
}
