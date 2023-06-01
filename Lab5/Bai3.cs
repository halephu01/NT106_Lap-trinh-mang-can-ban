using MailKit.Net.Imap;
using MailKit;
using OpenPop.Mime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OpenPop.Pop3;


namespace Lab5
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbPassword.Text = "fplfmqzlwutttpjf";
            tbUsername.Text = "phuha3650@gmail.com";
        }

        private void btLoginImap_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty && tbPassword.Text != string.Empty)
                ReadMailIMAP();
        }

        void ReadMailIMAP()
        {
            listView.Items.Clear();
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);

                    client.Authenticate(tbUsername.Text, tbPassword.Text);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lbTotal.Text = inbox.Count.ToString();
                    lbRecent.Text = inbox.Count.ToString();
                    lbTotal.Visible = true;
                    lbRecent.Visible = true;

                    for (int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = message.Subject;

                        string subject = message.Subject;
                        string from = message.From.ToString();
                        DateTime date = message.Date.DateTime;

                        item = new ListViewItem(new string[] { subject, from, date.ToString() });
                        listView.Items.Add(item);
                    }
                }
            }
            catch
            {

            }
        }

        void ReadMailPOP()
        {
            listView.Items.Clear();

            try
            {
                Pop3Client pop3Client = new Pop3Client();
                pop3Client.Connect("pop.gmail.com", 995, true); 
                pop3Client.Authenticate(tbUsername.Text, tbPassword.Text); 

                int messageCount = pop3Client.GetMessageCount();

                lbTotal.Text = messageCount.ToString();
                lbRecent.Text = messageCount.ToString();
                lbTotal.Visible= true;
                lbRecent.Visible= true;

                for (int i = 1; i <= messageCount; i++)
                {
                    OpenPop.Mime.Message message = pop3Client.GetMessage(i);
                    string subject = message.Headers.Subject;
                    string from = message.Headers.From.DisplayName;
                    DateTime date = message.Headers.DateSent;

                    ListViewItem item = new ListViewItem(new string[] { subject, from, date.ToString() });
                    listView.Items.Add(item);
                }
            }
            catch
            {

            }
        }

        private void btLoginPop_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != string.Empty && tbPassword.Text != string.Empty)
                ReadMailPOP();

        }
    }
}
