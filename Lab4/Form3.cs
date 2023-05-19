using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;
using System.Xml.Linq;
using System.Diagnostics;


namespace Lab4
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bt_download_Click(object sender, EventArgs e)
        {
            string url = tb_URL.Text;
            string fileUrl = tb_path.Text;

            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, fileUrl);

            using (StreamReader sr = new StreamReader(fileUrl))
            {
                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
            }
        }
    }
}
