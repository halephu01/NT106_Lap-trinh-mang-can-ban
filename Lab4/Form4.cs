using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tbUrl.Text);
        }

        private string getSource(string strURL)
        {
            try
            {
                HtmlWeb web = new HtmlWeb();
                HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                doc = web.Load(strURL);
                string s = doc.Text;
                return s;
            }
            catch
            {
                return "URL không tồn tại!";
            }
        }

        private async void btDownload_Click(object sender, EventArgs e)
        {
            if (getSource(tbUrl.Text) == "URL không tồn tại!")
            {

            }
            else
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "HTML|*.html", ValidateNames = true })
                {

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteLineAsync(getSource(tbUrl.Text));
                            MessageBox.Show("Bạn đã tải source thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void btViewSource_Click(object sender, EventArgs e)
        {
            if (getSource(tbUrl.Text) == "URL không tồn tại!")
            {

            }
            else
            {
                SourceHTML source = new SourceHTML(getSource(tbUrl.Text));
                source.Show();
            }
        }
    }
}
