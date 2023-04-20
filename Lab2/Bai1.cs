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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            txtData.Text = content;
            fs.Close();
        }

        private void btGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            try
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    string content = txtData.Text;
                    content = content.ToUpper();
                    writer.WriteLine(content);
                }
                MessageBox.Show("Bạn tạo file Output thành công ", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập tên file", "Thông báo");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
