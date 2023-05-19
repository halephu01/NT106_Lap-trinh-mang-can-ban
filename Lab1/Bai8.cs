using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Lab1
{
    public partial class Bai8 : Form
    {
        public Bai8()
        {
            InitializeComponent();
        }

        private void Bai8_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXuat_Click(object sender, EventArgs e)
        {
            string[] txt = tbData.Text.Split(',');
            bool check = true;
            string strReg = @"(/^[a-zA-Z])|(\d\.\d)|(^\d$)|(\d\d)";     
            Regex re = new Regex(strReg);

            if (txt.Length != 13)
            {
                MessageBox.Show("Chưa nhập tên hoặc chưa đủ điểm!");
            }
            else
            {
                for (int i = 1; i < 13; i++)
                {
                    if (!re.IsMatch(txt[i]))
                    {
                        check = false; 
                        break;
                    }
                    else
                    {
                        double temp = double.Parse(txt[i]);
                        if (temp > 10 || temp < 0)
                        {
                            check = false; 
                            break;
                        }
                    }
                }
                if (!check)
                {
                    MessageBox.Show("Xin nhập lại tên hoặc điểm!");
                }
                else
                {
                    double dtb_Mon = 0, max_Diem = 0, min_Diem = 99;
                    int dem_d1 = 0, dem_d2 = 0, dem_d3 = 0, dem_d4 = 0, soMonDau = 0, soMonKhongDau = 0;
                    string xepLoai;
                    double[] arr = new double[12];
                    for (int i = 0; i < 12; i++)
                    {
                        arr[i] = double.Parse(txt[i+1]);
                        dtb_Mon = dtb_Mon + arr[i];
                    }
                    dtb_Mon = dtb_Mon / 12;
                    for (int i = 0; i < 12; i++)
                    {
                        if (arr[i] >= max_Diem) 
                            max_Diem = arr[i];
                        if (arr[i] <= min_Diem) 
                            min_Diem = arr[i];
                        if (arr[i] < 2) 
                            dem_d4++;
                        else if (arr[i] < 3.5) 
                            dem_d3++;
                        else if (arr[i] < 5) 
                            dem_d2++;
                        else if (arr[i] < 6.5) 
                            dem_d1++;
                        if (arr[i] >= 5) 
                            soMonDau++;
                        else 
                            soMonKhongDau++;
                    }
                    if (dtb_Mon >= 8 && dem_d1 == 0) 
                        xepLoai = "Giỏi";
                    else if (dtb_Mon >= 6.5 && dem_d2 == 0) 
                        xepLoai = "Khá";
                    else if (dtb_Mon >= 5 && dem_d3 == 0) 
                        xepLoai = "Trung bình";
                    else if (dtb_Mon >= 3.5 && dem_d4 == 0) 
                        xepLoai = "Yếu";
                    else 
                        xepLoai = "Kém";

                    btTenSV.Text = txt[0];
                    tbDiemTB.Text = dtb_Mon.ToString();
                    tbDiemCaoNhat.Text = max_Diem.ToString();
                    tbSoMonDau.Text = soMonDau.ToString();
                    tbXepLoai.Text = xepLoai;
                    tbDiemThapNhat.Text = min_Diem.ToString();
                    tbSoMonKhongDau.Text = soMonKhongDau.ToString();

                    tbMon1.Text = arr[0].ToString();
                    tbMon2.Text = arr[1].ToString();
                    tbMon3.Text = arr[2].ToString();
                    tbMon4.Text = arr[3].ToString();
                    tbMon5.Text = arr[4].ToString();
                    tbMon6.Text = arr[5].ToString();
                    tbMon7.Text = arr[6].ToString();
                    tbMon8.Text = arr[7].ToString();
                    tbMon9.Text = arr[8].ToString();
                    tbMon10.Text = arr[9].ToString();
                    tbMon11.Text = arr[10].ToString();
                    tbMon12.Text = arr[11].ToString();
                }
            }
        }

        private void btTenSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbDiemThapNhat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            tbData.Text = string.Empty;
            btTenSV.Text = string.Empty;
            tbDiemTB.Text = string.Empty;
            tbDiemCaoNhat.Text = string.Empty;
            tbSoMonDau.Text = string.Empty;
            tbXepLoai.Text = string.Empty;
            tbDiemThapNhat.Text = string.Empty;
            tbSoMonKhongDau.Text = string.Empty;
            tbMon1.Text = string.Empty;
            tbMon2.Text = string.Empty;
            tbMon3.Text = string.Empty;
            tbMon4.Text = string.Empty;
            tbMon5.Text = string.Empty;
            tbMon6.Text = string.Empty;
            tbMon7.Text = string.Empty;
            tbMon8.Text = string.Empty;
            tbMon9.Text = string.Empty;
            tbMon10.Text = string.Empty;
            tbMon11.Text = string.Empty;
            tbMon12.Text = string.Empty;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
