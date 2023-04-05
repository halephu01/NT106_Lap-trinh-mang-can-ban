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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int ck1, ck2;
            if (!Int32.TryParse(tbA.Text, out ck1) || !Int32.TryParse(tbB.Text, out ck2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên!");
            }
            else
            {
                int a, b;
                long gtA, gtB, s1, s2, s3;
                gtA = 1;
                gtB = 1;
                s1 = 0;
                s2 = 0;
                s3 = 0;
                a = Int32.Parse(tbA.Text);
                b = Int32.Parse(tbB.Text);

                for (int i = 1; i < a + 1; i++)
                {
                    gtA = gtA * i;
                }

                for (int i = 1; i < b + 1; i++)
                {
                    gtB = gtB * i;
                }

                for (int i = 1; i < a + 1; i++)
                {
                    s1 = s1 + i;
                }

                for (int i = 1; i < b + 1; i++)
                {
                    s2 = s2 + i;
                }

                for (int i = 1; i < b + 1; i++)
                {
                    s3 = (long)(s3 + Math.Pow(a, i));
                }
                string ketqua = "";
                ketqua = ketqua + "\n";
                ketqua = ketqua + "     A! = " + gtA + "                                 ";
                ketqua = ketqua + "     B! = " + gtB + "\n\n";
                ketqua = ketqua + "     S1 = 1 + 2 + 3 + 4 + ... + A = " + s1 + "\n\n";
                ketqua = ketqua + "     S2 = 1 + 2 + 3 + 4 + ... + B = " + s2 + "\n\n";
                ketqua = ketqua + "     S3 = A^1 + A^2 + A^3 + A^4 + ... + A^B = " + s3;

                rtbKetQua.Text = ketqua;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbA.Text = string.Empty;
            tbB.Text = string.Empty;
            rtbKetQua.Text = string.Empty;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
