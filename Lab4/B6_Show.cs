using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class B6_Show : Form
    {
        public B6_Show()
        {
            InitializeComponent();
        }

        private void B6_Show_Load(object sender, EventArgs e)
        {

        }

        WebBrowser webBrowser1 = new WebBrowser();
        public B6_Show(string url)
        {
            InitializeComponent();
            //webBrowser1.AllowWebBrowserDrop = false;
            webBrowser1.Url = new Uri(url);
            webBrowser1.ScriptErrorsSuppressed = true; //phớt lờ lỗi ScriptError
            webBrowser1.Width = 800;
            webBrowser1.Height = 450;
            //Hiển thị trang web lên panel của form
            panel1.Controls.Add(webBrowser1);
        }
    }
}
