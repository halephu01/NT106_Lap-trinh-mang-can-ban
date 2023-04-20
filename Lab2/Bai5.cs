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
using System.IO.Compression;

namespace Lab2
{
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void Bai5_Load(object sender, EventArgs e)
        {

        }

        private void btNen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtData.Text))
            {
                MessageBox.Show("Vui lòng nhập dữ liệu cần nén!");
            }
            // Hiển thị hộp thoại chọn thư mục
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu tệp tin nén vào thư mục được chọn
                    string zipFilePath = Path.Combine(dialog.SelectedPath, "output5.zip");
                    using (FileStream zipToCreate = new FileStream(zipFilePath, FileMode.Create))
                    {
                        using (ZipArchive archive = new ZipArchive(zipToCreate, ZipArchiveMode.Create))
                        {
                            ZipArchiveEntry entry = archive.CreateEntry("output5.txt");
                            using (StreamWriter writer = new StreamWriter(entry.Open()))
                            {
                                writer.Write(txtData.Text);
                            }
                        }
                    }
                    MessageBox.Show("Đã nén dữ liệu thành công và lưu vào thư mục: " + dialog.SelectedPath);
                }
            }
        }

        private void btGiai_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Kiểm tra xem tệp tin "output5.zip" có tồn tại trong thư mục được chọn hay không
                    string zipFilePath = Path.Combine(dialog.SelectedPath, "output5.zip");
                    if (!File.Exists(zipFilePath))
                    {
                        MessageBox.Show("Không tìm thấy tệp tin output5.zip trong thư mục được chọn!");
                        return;
                    }
                    // Giải nén tệp tin "output5.zip" và lưu trữ dưới dạng "output5.txt" trong thư mục được chọn
                    using (ZipArchive archive = ZipFile.OpenRead(zipFilePath))
                    {
                        ZipArchiveEntry entry = archive.GetEntry("output5.txt");
                        using (StreamReader reader = new StreamReader(entry.Open()))
                        {
                            string extractedData = reader.ReadToEnd();
                            string extractedFilePath = Path.Combine(dialog.SelectedPath, "output5.txt");
                            File.WriteAllText(extractedFilePath, extractedData);
                        }
                    }
                    MessageBox.Show("Đã giải nén dữ liệu thành công và lưu vào thư mục: " + dialog.SelectedPath);
                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

