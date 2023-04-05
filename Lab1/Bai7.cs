using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Bai7 : Form
    {
        public Bai7()
        {
            InitializeComponent();
        }

        private void btTinh_Click(object sender, EventArgs e)
        {
            int[] arr = new int[4];
            arr[0] = Int32.Parse(tbIP_1.Text);
            arr[1] = Int32.Parse(tbIP_2.Text);
            arr[2] = Int32.Parse(tbIP_3.Text);
            arr[3] = Int32.Parse(tbIP_4.Text);
            if (arr[0] > 223 || arr[1] > 255 || arr[1] < 0 || arr[2] > 255 || arr[2] < 0 || arr[3] < 0 || arr[3] > 255)
            {
                MessageBox.Show("Vui long nhập lại!");
            }
            else
            {
                int subnet, soMang, NetID, HostID;
                subnet = Int32.Parse(tbSubnet.Text);
                soMang = Int32.Parse(tbSoMang.Text);
                if (arr[0] > 191 && arr[0] < 224)
                {
                    if (subnet < 24 || subnet > 32 || soMang > 2097158 || soMang < 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại Subnet Mask hoặc số mạng!");
                    }
                }
                if (arr[0] > 127 && arr[0] < 192)
                {
                    if(subnet < 16 || subnet > 32|| soMang > 16384 || soMang < 0)
                    {
                        MessageBox.Show("Vui lòng nhập lại Subnet Mask hoặc số mạng!");
                    }
                }
                if (arr[0] > 0 && arr[0] < 127)
                {
                    if (subnet < 8 || subnet > 32 || soMang < 0 || soMang > 128) 
                    {
                        MessageBox.Show("Vui lòng nhập lại Subnet Mask hoặc số mạng!");
                    }
                }

                int bitMuon = 0, STT = 1;
                for (int i = 0; i < soMang; i++)
                {
                    if (Math.Pow(2, i) >= soMang)
                    {
                        bitMuon = i;
                        STT = (int)Math.Pow(2, i);
                        break;
                    }
                }

                int buocNhay;
                NetID = subnet + bitMuon;
                HostID = 32 - NetID;

                for (int i = 1; i <= STT; i++)
                {
                    ListViewItem item = new ListViewItem(i.ToString());

                    string diaChiMang = "", diaChiDau = "", diaChiCuoi = "", broadcast = "";

                    if (arr[0] > 0 && arr[0] < 127)
                    {
                        buocNhay = (int)Math.Pow(2, 8 - bitMuon);
                        broadcast = broadcast + arr[0] + "." + (int)(arr[1] + buocNhay - 1) + ".255.255";
                        diaChiCuoi = diaChiCuoi + arr[0] + "." + (int)(arr[1] + buocNhay - 1) + ".255.254";
                        diaChiDau = diaChiDau + arr[0] + "." + arr[1] + ".0.1";
                        diaChiMang = diaChiMang + arr[0] + "." + arr[1] + "." + arr[2] + "." + arr[3];
                        arr[1] = arr[1] + buocNhay;
                    }
                    else if (arr[0] > 126 && arr[0] < 192)
                    {
                        buocNhay = (int)Math.Pow(2, 8 - bitMuon);

                        broadcast = broadcast + arr[0] + "." + arr[1] + "." + (int)(arr[2] + buocNhay - 1) + ".255";
                        diaChiCuoi = diaChiCuoi + arr[0] + "." + arr[1] + "." + (int)(arr[2] + buocNhay - 1) + ".254";
                        diaChiDau = diaChiDau + arr[0] + "." + arr[1] + "." + arr[2] + ".1";
                        diaChiMang = diaChiMang + arr[0] + "." + arr[1] + "." + arr[2] + "." + arr[3];
                        arr[2] = arr[2] + buocNhay;
                    }
                    else
                    {
                        buocNhay = (int)Math.Pow(2, 8 - bitMuon);
                        diaChiMang = diaChiMang + arr[0] + "." + arr[1] + "." + arr[2] + "." + arr[3];
                        diaChiDau = diaChiDau + arr[0] + "." + arr[1] + "." + arr[2] + "." + (int)(arr[3] + 1);
                        diaChiCuoi = diaChiCuoi + arr[0] + "." + arr[1] + "." + arr[2] + "." + (int)(arr[3] + buocNhay - 2);
                        broadcast = broadcast + arr[0] + "." + arr[1] + "." + arr[2] + "." + (int)(arr[3] + buocNhay - 1);
                        arr[3] = arr[3] + buocNhay;
                    }

                    item.SubItems.Add(diaChiMang);
                    item.SubItems.Add(diaChiDau);
                    item.SubItems.Add(diaChiCuoi);
                    item.SubItems.Add(broadcast);
                    listView.Items.Add(item);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Bai7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            tbIP_1.Text = string.Empty;
            tbIP_2.Text = string.Empty;
            tbIP_3.Text = string.Empty;
            tbIP_4.Text = string.Empty;
            tbSoMang.Text = string.Empty;
            tbSubnet.Text = string.Empty;
        }
    }
}
