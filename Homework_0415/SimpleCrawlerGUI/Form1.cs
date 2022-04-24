using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleCrawler;

namespace SimpleCrawlerGUI
{
    public partial class Form1 : Form
    {
        private SimpleCrawler.SimpleCrawler myCrawler = null;

        public string url { set; get; }
        // public string output { get; set; }

        public Form1()
        {
            InitializeComponent();
            myCrawler = new SimpleCrawler.SimpleCrawler();
            txtSpecifiedUrl.DataBindings.Add("Text", myCrawler, "startUrl");
            cbSpecified.DataBindings.Add("Checked", myCrawler, "onlySpecified");
            //lbOutput.DataBindings.Add("Text", myCrawler, "output");

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            myCrawler.OnOutput += new OutputHandler(CrawlerOnOntput);
            
            myCrawler.StartCrawl();
            //lbOutput.ResetBindings();
        }

        private void CrawlerOnOntput(object sender, OutputEventArgs e)
        {
            txtOutput.Invoke(new MethodInvoker(() => txtOutput.AppendText(e.output)));
        }


    }
}
