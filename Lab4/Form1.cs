using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);       // Create a request for the URL.
            WebResponse response = request.GetResponse();        // Get the response. 
            Stream dataStream = response.GetResponseStream();    // Get the stream containing content returned by the server. 
            StreamReader reader = new StreamReader(dataStream);  // Open the stream using a StreamReader for easy access.  
            string responseFromServer = reader.ReadToEnd();      // Read the content.
            response.Close();                                    // Close the response. 
            return responseFromServer;
        }

        private void bt_GET_Click(object sender, EventArgs e)
        {
            rtb_HTML.Text = getHTML(tb_URL.Text);
        }
    }
}
