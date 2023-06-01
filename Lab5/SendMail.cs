using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab5
{
    public partial class SendMail : Form
    {
        public SendMail(string tk, string mk, string to,string portSMTP)
        {
            InitializeComponent();
            tbFrom.Text = tk;
            tbTo.Text = to;
            tbMatKhau.Text = mk;
            tbPortSMTP.Text = portSMTP;
            tbFrom.Enabled = false;

            tbMatKhau.Text = "fplfmqzlwutttpjf";
            tbPortSMTP.Text = 465.ToString();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient();
            int port = Int32.Parse(tbPortSMTP.Text);
            textBox1.Text = port.ToString();

            smtpClient.Connect("smtp.gmail.com", port, true);
            try
            {
                string tk = tbFrom.Text, mk = tbMatKhau.Text;
                smtpClient.Authenticate(tk, mk);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(tbName.Text, tbFrom.Text));
            message.To.Add(new MailboxAddress("", tbTo.Text));
            message.Subject = tbSubject.Text;

            var bodyBuilder = new BodyBuilder();        

            if (checkBox1.Checked)
            {
                bodyBuilder.HtmlBody = rtbBody.Text;

                var plainText = bodyBuilder.HtmlBody;
                bodyBuilder.TextBody = plainText;
            }
            else
            {
                bodyBuilder.TextBody = rtbBody.Text;
            }

            if (tbPath.Text != string.Empty)
            {             
                var attachment = new MimePart("application", "octet-stream")
                {
                    Content = new MimeContent(File.OpenRead(tbPath.Text)),
                    ContentDisposition = new ContentDisposition(ContentDisposition.Attachment),
                    ContentTransferEncoding = ContentEncoding.Base64,
                    FileName = Path.GetFileName(tbPath.Text)
                };
                bodyBuilder.Attachments.Add(attachment);
            }           
            message.Body = bodyBuilder.ToMessageBody();
            
            smtpClient.Send(message);
        }

        private void btBrowser_Click(object sender, EventArgs e)
        {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
         
                if (openFileDialog.ShowDialog() == DialogResult.OK)                       
                    tbPath.Text = openFileDialog.FileName;
            
        }
    }
}
