using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bt_post_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(tb_URL.Text);    //Creat a request using a URL
            request.Method = "POST";                                // Set the method of request to POST

            string postData = tb_data.Text;                         // Create POST data and covert to a byte array
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);    
            request.ContentType = "application/x-www-form-urlencoded";      //Set the ContentType property of the WebRequest
            request.ContentLength = byteArray.Length;                       //Set the ContentLength property of the WebRequest

            Stream dataStream = request.GetRequestStream();             //Get the request stream
            dataStream.Write (byteArray, 0, byteArray.Length);          //Write the data to the request stream
            dataStream.Close();                                         //Close the Stream obbject

            WebResponse reponse = request.GetResponse();                //Get the response    
            dataStream = reponse.GetResponseStream();                   //Get the stream containing content returned by the server
            StreamReader reader = new StreamReader(dataStream);         //Open the stream
            string responseFromServer = reader.ReadToEnd();             //Read the content

            richTextBox1.Text = responseFromServer;                     //Display the content
            reader.Close();
            dataStream.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
