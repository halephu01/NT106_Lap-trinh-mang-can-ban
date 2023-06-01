using MimeKit;
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
using MailKit.Net.Imap;
using MailKit;
using System.Net.Mail;

namespace Lab5
{
    public partial class Bai4 : Form
    {
        ImapClient client = new ImapClient();
        private List<MimeMessage> emails = new List<MimeMessage>();
        private Dictionary<string, MimeMessage> emailDictionary = new Dictionary<string, MimeMessage>();

        public Bai4()
        {
            InitializeComponent();
            tbMatKhau.PasswordChar = '*';
            tbMatKhau.Text = "fplfmqzlwutttpjf";
            tbTaiKhoan.Text = "phuha3650@gmail.com";
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                ReadMailIMAP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            btDangNhap.Visible = false;
            btDangXuat.Visible = true;
            btGuiMail.Visible = true;
            btRefresh.Visible = true;
        }

        void ReadMailIMAP()
        {
            try
            {
                client.Connect("imap.gmail.com", Convert.ToInt32(numPortIMAP.Value), true);
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;
                client.Authenticate(tbTaiKhoan.Text, tbMatKhau.Text);

                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    emails.Add(message);
                }

                // Hiển thị danh sách email trong ListView
                listView.Items.Clear();
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);

                    ListViewItem item = new ListViewItem();

                    item.Text = message.Subject;
                    string thuTu = (i + 1).ToString();
                    string subject = message.Subject;
                    string from = message.From.ToString();
                    DateTime date = message.Date.DateTime;

                    item = new ListViewItem(new string[] { thuTu, subject, from, date.ToString() });

                    item.Tag = message.MessageId;

                    emailDictionary[message.MessageId] = message;

                    listView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btGuiMail_Click(object sender, EventArgs e)
        {
            string from = tbTaiKhoan.Text, mk = tbMatKhau.Text, to = "", portSMTP = Convert.ToString(numPortSMTP.Value);
            SendMail sendMail = new SendMail(from, mk, to, portSMTP);
            sendMail.Show();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            string portSMTP = Convert.ToString(numPortSMTP.Value);
            string mk=tbMatKhau.Text;
            if (listView.SelectedItems.Count > 0)
            {
                int emailIndex = listView.SelectedItems[0].Index;

                MimeMessage email = emails[emailIndex];

                EmailDetailsForm detail = new EmailDetailsForm(email: email,portSMTP,mk);

                detail.ShowDialog();
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            client.Disconnect(true);
            listView.Items.Clear();
            tbTaiKhoan.Clear();
            tbMatKhau.Clear();
            tbIMAP.Clear();
            tbSMTP.Clear();
            numPortIMAP.Value = 0;
            numPortSMTP.Value = 0;
            btDangNhap.Visible = true;
            btGuiMail.Visible = false;
            btRefresh.Visible = false;
            btDangXuat.Visible = false;
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            client.Disconnect(true);
            ReadMailIMAP();
        }
    }
}
