using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btDoc_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            txtData.Text = content;

            txtTen.Text = ofd.SafeFileName.ToString();
            txtUrl.Text = fs.Name.ToString();
            int soDong, soTu, soKyTu;

            soKyTu = content.Length;

            content = content.Replace("\r\n", "\r");
            soDong = txtData.Lines.Count();

            content = content.Replace('\r', ' ');
            string[] source = content.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            soTu = source.Count();

            txtSoDong.Text = soDong.ToString();
            txtSoKyTu.Text = soKyTu.ToString();
            txtSoTu.Text = soTu.ToString();

            fs.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
