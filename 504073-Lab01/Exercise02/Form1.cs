using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (WebClient myWebClient = new WebClient())
            {
                string url = txtUrl.Text;
                string filename = Path.GetFileName(url);
                myWebClient.DownloadFile(url, filename);

            
                MessageBox.Show("Download complete");
                Process.Start("explorer.exe",Directory.GetCurrentDirectory());
            }
        }

        private void btnDownloadAsync_Click(object sender, EventArgs e)
        {

        }
    }
}
