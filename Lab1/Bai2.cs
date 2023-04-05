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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTim_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, min, max;
            double a, b, c;
            if (!Double.TryParse(tbSoThuNhat.Text, out a) || !Double.TryParse(tbSoThuHai.Text, out b) || !Double.TryParse(tbSoThuBa.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập số!");
            }
            else
            {
                num1 = Double.Parse(tbSoThuNhat.Text.Trim());
                num2 = Double.Parse(tbSoThuHai.Text.Trim());
                num3 = Double.Parse(tbSoThuBa.Text.Trim());

                min = Math.Min(Math.Min(num1, num2), num3);
                max = Math.Max(Math.Max(num1, num2), num3);

                tbSoLonNhat.Text = max.ToString();
                tbSoNhoNhat.Text = min.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbSoThuNhat.Text = string.Empty;
            tbSoThuHai.Text = string.Empty;
            tbSoThuBa.Text = string.Empty;
            tbSoLonNhat.Text = string.Empty;
            tbSoNhoNhat.Text = string.Empty;
        }

        private void Thoát_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
