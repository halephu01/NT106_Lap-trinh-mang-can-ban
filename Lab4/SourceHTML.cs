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
    public partial class SourceHTML : Form
    {
        public SourceHTML()
        {
            InitializeComponent();
        }

        private void SourceHTML_Load(object sender, EventArgs e)
        {

        }

        public SourceHTML(string source) : this()
        {
            rtbSource.Text = source;
        }
    }
}
