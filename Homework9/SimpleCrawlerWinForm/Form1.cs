using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;

namespace SimpleCrawlerWinForm
{
    public partial class Form1 : Form
    {
        BindingSource resultBindingSource = new BindingSource();
        Crawler crawler = new Crawler();

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = resultBindingSource;
            crawler.CrawlerStopped += Crawler_CrawlerStopped;
            crawler.PageDownloaded += Crawler_PageDownloaded;
        }

        private void Crawler_CrawlerStopped(Crawler obj)
        {
            Action action = () => label1.Text = "爬虫已停止";
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void Crawler_PageDownloaded(Crawler crawler, string url, string info)
        {
            var pageInfo = new { Index = crawler.count, URL = url, Status = info };
            Action action = () => { resultBindingSource.Add(pageInfo); };
            if (this.InvokeRequired)
            {
                this.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultBindingSource.Clear();
            crawler.startUrl = urlTextBox.Text;

            Match match = Regex.Match(crawler.startUrl, crawler.parseRef);
            if (match.Length == 0) return;
            string host = match.Groups["host"].Value;
            crawler.HostFilter = "^" + host + "$";
            crawler.FileFilter = ".(html?|aspx|jsp|php)$|^[^.]*$";
            Task.Run(() => crawler.Start());
            label1.Text = "爬虫已启动....";
        }
    }
}
