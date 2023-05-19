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
    public partial class Bai3_1 : Form
    {
        public Bai3_1()
        {
            InitializeComponent();
        }

        private void tbKetqua_TextChanged(object sender, EventArgs e)
        {
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            int a;
            if (!Int32.TryParse(tbSo.Text, out a) || Int32.Parse(tbSo.Text) < 0 || Int32.Parse(tbSo.Text) > 9999)
            {
                MessageBox.Show("Vui lòng nhập số trong khoảng từ 0 đến 9999");
            }
            else
            {
                int num, m, n;

                num = Int32.Parse(tbSo.Text);
                m = num;
                string[] don = { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín", "Mười" };
                string[] chuc = { "Hai Mươi", "Ba Mươi", "Bốn Mươi", "Năm Mươi", "Sáu Mươi", "Bảy Mươi", "Tám Mươi", "Chín Mươi" };
                string ketqua = "";

                if (999 < num && num < 10000)
                {
                    n = num / 1000;
                    ketqua = ketqua + don[n] + " Ngàn" + " ";
                    num = num % 1000;
                }

                if (m > 999 && num < 100 && num / 100 == 0)
                {
                    ketqua = ketqua + don[0] + " Trăm ";
                }

                if (99 < num && num < 1000)
                {
                    n = num / 100;
                    ketqua = ketqua + don[n] + " Trăm ";
                    num = num % 100;
                }

                if (m > 99 && num / 10 == 0)
                {
                    ketqua = ketqua + "Lẻ ";
                }

                if (19 < num && num < 100)
                {
                    n = num / 10;
                    ketqua = ketqua + chuc[n - 2] + " ";
                    if (num % 10 == 1)
                        ketqua = ketqua + "Mốt";
                    else if (num % 10 == 5)
                        ketqua = ketqua + "Lăm";
                    else if (num % 10 > 1)
                        ketqua = ketqua + don[num % 10];
                }

                if (9 < num && num < 20)
                {
                    n = num % 10;
                    if (n == 5)
                        ketqua = ketqua + don[10] + " Lăm";
                    else if (n == 0)
                        ketqua = ketqua + don[10];
                    else
                        ketqua = ketqua + don[10] + " " + don[n];
                }

                if (num < 10)
                {
                    ketqua = ketqua + don[num];
                }
                tbKetqua.Text = ketqua;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbSo.Text = string.Empty;
            tbKetqua.Text = string.Empty;
        }
    }
}
