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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(tbSo.Text, out a) || Int32.Parse(tbSo.Text) < 0 || Int32.Parse(tbSo.Text) > 9)
            {
                MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 9");
            }
            else
            {
                int num;
                num = Int32.Parse(tbSo.Text);
                switch (num)
                {
                    case 0:
                        tbKetqua.Text = "Không";
                        break;
                    case 1:
                        tbKetqua.Text = "Một";
                        break;
                    case 2:
                        tbKetqua.Text = "Hai";
                        break;
                    case 3:
                        tbKetqua.Text = "Ba";
                        break;
                    case 4:
                        tbKetqua.Text = "Bốn";
                        break;
                    case 5:
                        tbKetqua.Text = "Năm";
                        break;
                    case 6:
                        tbKetqua.Text = "Sáu";
                        break;
                    case 7:
                        tbKetqua.Text = "Bảy";
                        break;
                    case 8:
                        tbKetqua.Text = "Tám";
                        break;
                    case 9:
                        tbKetqua.Text = "Chín";
                        break;
                }
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbSo.Text = string.Empty;
            tbKetqua.Text = string.Empty;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
