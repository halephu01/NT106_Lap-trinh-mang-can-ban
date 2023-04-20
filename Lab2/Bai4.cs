using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai4 : Form
    {
        int a = 0;
        public class Student
        {
            public string FullName { get; set; }
            public int MSSV { get; set; }
            public string PhoneNumber { get; set; }
            public float Mark1 { get; set; }
            public float Mark2 { get; set; }
            public float Mark3 { get; set; }
            public float AverageMark { get; set; }
        }

        private List<Student> students = new List<Student>();

        public Bai4()
        {
            InitializeComponent();
            btGhi.Enabled = false;
            btDoc.Enabled = false;
            txtHoTenDoc.Enabled = false;
            txtIDDoc.Enabled = false;
            txtSDTDoc.Enabled = false;
            txtD1Doc.Enabled = false;
            txtD2Doc.Enabled = false;
            txtD3Doc.Enabled = false;
            txtDTBDoc.Enabled = false;
            btTruoc.Enabled = false;
            btSau.Enabled = false;
            label7.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHoTenGhi.Text) || string.IsNullOrEmpty(txtIDGhi.Text) ||
                string.IsNullOrEmpty(txtSDTGhi.Text) || string.IsNullOrEmpty(txtD1Ghi.Text) ||
                string.IsNullOrEmpty(txtD2Ghi.Text) || string.IsNullOrEmpty(txtD3Ghi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin sinh viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string mssvText = txtIDGhi.Text;
            if (!int.TryParse(mssvText, out int mssv) || mssvText.Length != 8)
            {
                MessageBox.Show("Mã số sinh viên phải là một số nguyên có 8 chữ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSDTGhi.Text.Length != 10 || !txtSDTGhi.Text.StartsWith("0"))
            {
                MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float mark1, mark2, mark3;
            if (!float.TryParse(txtD1Ghi.Text, out mark1) || !float.TryParse(txtD2Ghi.Text, out mark2) || !float.TryParse(txtD3Ghi.Text, out mark3))
            {
                MessageBox.Show("Điểm phải là một số thực từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (mark1 < 0 || mark1 > 10 || mark2 < 0 || mark2 > 10 || mark3 < 0 || mark3 > 10)
                {
                    MessageBox.Show("Điểm phải là một số thực từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Student student = new Student
            {
                FullName = txtHoTenGhi.Text,
                MSSV = mssv,
                PhoneNumber = txtSDTGhi.Text,
                Mark1 = mark1,
                Mark2 = mark2,
                Mark3 = mark3,
                AverageMark = (mark1 + mark2 + mark3) / 3
            };
            students.Add(student);
            txtHoTenGhi.Text = "";
            txtIDGhi.Text = "";
            txtSDTGhi.Text = "";
            txtD1Ghi.Text = "";
            txtD2Ghi.Text = "";
            txtD3Ghi.Text = "";
            txtDTBghi.Text = "";

            txtNoiDung.AppendText($"{student.FullName}\n");
            txtNoiDung.AppendText($"{student.MSSV}\n");
            txtNoiDung.AppendText($"{student.PhoneNumber}\n");
            txtNoiDung.AppendText($"{student.Mark1}\n");
            txtNoiDung.AppendText($"{student.Mark2}\n");
            txtNoiDung.AppendText($"{student.Mark3}\n");
            txtNoiDung.AppendText("\n");
            btGhi.Enabled = true;
            MessageBox.Show("Thêm sinh viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            try
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    string a = txtNoiDung.Text;
                    bf.Serialize(fs, a);
                }
                MessageBox.Show("Ghi thành công dữ liệu vào File được chọn", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập tên file", "Thông báo");
            }
            btDoc.Enabled = true;
            btGhi.Enabled = false;
            txtHoTenGhi.Enabled = false;
            txtIDGhi.Enabled = false;
            txtSDTGhi.Enabled = false;
            txtD1Ghi.Enabled = false;
            txtD2Ghi.Enabled = false;
            txtD3Ghi.Enabled = false;
            txtDTBghi.Enabled = false;
            btThem.Enabled = false;
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Deserialize(fs);
            fs.Close();
            XemSV();
            foreach (Student student in students)
            {
                txtNoiDung2.AppendText($"{student.FullName}\n");
                txtNoiDung2.AppendText($"{student.MSSV}\n");
                txtNoiDung2.AppendText($"{student.PhoneNumber}\n");
                txtNoiDung2.AppendText($"{student.Mark1}\n");
                txtNoiDung2.AppendText($"{student.Mark2}\n");
                txtNoiDung2.AppendText($"{student.Mark3}\n");
                txtNoiDung2.AppendText($"{student.AverageMark}\n");
                txtNoiDung2.AppendText("\n");
            }
            btTruoc.Enabled = true;
            btSau.Enabled = true;
            if (a == 0) 
                btTruoc.Enabled = false;
            if (a == students.Count() - 1) 
                btSau.Enabled = false;
            btDoc.Enabled = false;
            MessageBox.Show("Đọc thành công File được chọn", "Thông báo");
        }

        void XemSV()
        {
            int n = students.Count();
            txtHoTenDoc.Text = students[a].FullName;
            txtIDDoc.Text = students[a].MSSV.ToString();
            txtSDTDoc.Text = students[a].PhoneNumber;
            txtD1Doc.Text = students[a].Mark1.ToString();
            txtD2Doc.Text = students[a].Mark2.ToString();
            txtD3Doc.Text = students[a].Mark3.ToString();
            txtDTBDoc.Text = students[a].AverageMark.ToString();
            label7.Text = a + 1 + "/" + n.ToString();
        }

        private void btnTruoc_Click(object sender, EventArgs e)
        {
            btSau.Enabled = true;
            if (a-- == 1) btTruoc.Enabled = false;
            XemSV();
        }

        private void btnSau_Click(object sender, EventArgs e)
        {
            btTruoc.Enabled = true;
            if (++a == students.Count() - 1) btSau.Enabled = false;
            XemSV();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhi2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = "txt";
            sfd.ShowDialog();
            try
            {
                using (StreamWriter writer = new StreamWriter(sfd.FileName))
                {
                    string a = txtNoiDung.Text;
                    writer.WriteLine(a);
                }
                MessageBox.Show("Bạn tạo File đã tính Điểm trung bình thành công ", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập tên file", "Thông báo");
            }
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void txtNoiDung2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }
    }
}
