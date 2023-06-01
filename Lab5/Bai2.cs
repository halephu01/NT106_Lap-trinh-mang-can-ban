using MailKit.Net.Imap;
using MailKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MailKit.Net.Pop3;

namespace Lab5
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            tbPassword.PasswordChar = '*';
            tbPassword.Text = "fplfmqzlwutttpjf";
            tbUsername.Text = "phuha3650@gmail.com";
        }

        void ReadMail()
        {
            try
            {
                using (var client = new ImapClient())
                {
                    client.Connect("imap.gmail.com", 993, true);
                    var popClient = new Pop3Client();

                    client.Authenticate(tbUsername.Text, tbPassword.Text);

                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);

                    lbTotal.Text = lbTotal.Text + inbox.Count.ToString();
                    lbRecent.Text=lbRecent.Text + inbox.Count.ToString();

                    for(int i = 0; i < inbox.Count; i++)
                    {
                        var message = inbox.GetMessage(i);

                        ListViewItem item = new ListViewItem();
                        item.Text = message.Subject;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.From.ToString() });
                        item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = message.Date.Date.ToString() });
                        listView1.Items.Add(item);
                    }
                }
            }
            catch
            {

            }
        } 

        private void btLogin_Click(object sender, EventArgs e)
        {
            if ((tbUsername.Text != string.Empty) && (tbPassword.Text != string.Empty))
            {
                ReadMail();
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
