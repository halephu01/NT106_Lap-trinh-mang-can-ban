using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.Security.Cryptography;
using MimeKit;

namespace Lab5
{
    public partial class EmailDetailsForm : Form
    {
        private MimeMessage email;

        public EmailDetailsForm(MimeMessage email, string mk, string portSMTP)
        {
            InitializeComponent();
            this.email = email;
            LoadHtmlAsync();
            tbMatKhau.Text = mk;
            tbPortSMTP.Text = portSMTP;
        }

        private void LoadHtmlAsync()
        {
            lbFrom.Text = email.From.ToString();
            lbTo.Text = email.To.ToString();
            lbSubject.Text = email.Subject;
            this.Text = email.Subject;

            lbFrom.Visible = true;
            lbTo.Visible = true;

            webView_mail.DocumentText = email.HtmlBody;
        }

        private void btReply_Click(object sender, EventArgs e)
        {
            string from = lbFrom.Text, to = lbTo.Text, mk = tbMatKhau.Text, portSMTP = tbPortSMTP.Text;
            SendMail replyMail = new SendMail(to, mk, from,portSMTP);
            replyMail.ShowDialog();
        }

        private void tbPortSMTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void webView_mail_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void lbSubject_Click(object sender, EventArgs e)
        {

        }

        private void lbTo_Click(object sender, EventArgs e)
        {

        }

        private void lbFrom_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
