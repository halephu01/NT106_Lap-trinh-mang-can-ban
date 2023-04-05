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
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            string loaixe = this.cbLoaiXe.SelectedItem.ToString();
            if (loaixe == "Wave Alpha" || loaixe == "Sirius"||loaixe=="Vision")
            {
                cbLoaiXang.Items.Remove("Dầu DO");
            }

            if (loaixe == "Lead" || loaixe == "Winner" || loaixe == "AirBlade")
            {
                cbLoaiXang.Items.Remove("Dầu DO");
                cbLoaiXang.Items.Remove("RON 95-III");
            }

            if(loaixe=="Xe tải 9 tấn")
            {
                cbLoaiXang.Items.Remove("RON 95-III");
                cbLoaiXang.Items.Remove("ES RON 92-II");
            }
        }

        private void tbKm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            string loaixe = this.cbLoaiXe.SelectedItem.ToString();
            string loaixang = this.cbLoaiXang.SelectedItem.ToString();
            string km = "";
            string tien = "";

            if (loaixe == "Wave Alpha")
            {
                km = km + "250 km";
                if (loaixang == "RON 95-III")
                {
                    tien = tien + "99.271 đồng";
                }

                if(loaixang=="ES RON 92-II")
                {
                    tien = tien + "96.459 đồng";
                }
            }

            if (loaixe == "Sirius")
            {
                km = km + "190.95 km";
                if(loaixang=="RON 95-III")
                {
                    tien = tien + "101.954 đồng";
                }
                if(loaixang=="ES RON 92-II")
                {
                    tien = tien + "99.066 đồng";
                }
            }

            if (loaixe == "Vision")
            {
                km = km + "278.07 km";
                if(loaixang=="RON 95-III")
                {
                    tien = tien + "139.516 đồng";
                }
                if(loaixang=="ES RON 92-II")
                {
                    tien = tien + "135.564 đồng";
                }
            }

            if (loaixe == "Winner")
            {
                km = km + "264.71 km ";
                tien = tien + "120.735 đồng";
            }

            if (loaixe == "AirBlade")
            {
                km = km + "202.76 km ";
                tien = tien + "118.052 đồng";
            }

            if (loaixe == "Lead")
            {
                km = km + "297.03 km ";
                tien = tien + "160.980 đồng";
            }

            if (loaixe=="Xe tải 9 tấn")
            {
                km = km + "507.14 km";
                tien = tien + "1.491.700 đồng";
            }

            tbKm.Text = km;
            tbTien.Text = tien;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
