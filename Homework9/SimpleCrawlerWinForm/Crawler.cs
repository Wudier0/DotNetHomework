using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;


namespace SimpleCrawlerWinForm
{
    class Crawler
    {
        private Hashtable urls = new Hashtable();
        public string startUrl { get; set; }
        public int count;

        public event Action<Crawler> CrawlerStopped;
        public event Action<Crawler, string, string> PageDownloaded;

        public string HostFilter { get; set; }
        public string FileFilter { get; set; }

        public string strRef = @"(href|HREF)[]*=[]*[""'](?<url>[^""'#>]+)[""']";
        public string parseRef = @"^(?<site>(?<protocal>https?)://(?<host>[\w\d.-]+)(:\d+)?($|/))(\w+/)*(?<file>[^#?]*)";

        public void Start()
        {
            urls.Clear();
            urls.Add(startUrl, false);
            count = 0;

            while (true)
            {
                string current = null;
                try
                {
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                    }

                    if (current == null) break;
                    Console.WriteLine("爬行" + current + "页面!");
                    string html = Download(current); // 下载
                    urls[current] = true;
                    count++;
                    PageDownloaded(this, current, "Success!");
                    Parse(html, current);//解析,并加入新的链接
                }catch(Exception ex)
                {
                    PageDownloaded(this, current, "Error:" + ex.Message);
                }
            }

            CrawlerStopped(this);

        }

        public string Download(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html, string url)
        {
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                string linkUrl = match.Groups["url"].Value;
                if (linkUrl == null || linkUrl == "" || linkUrl.StartsWith("javascript:")) continue;
                linkUrl = FixUrl(linkUrl, url);//转绝对路径
                //解析出host和file两个部分，进行过滤
                Match linkUrlMatch = Regex.Match(linkUrl, parseRef);
                string host = linkUrlMatch.Groups["host"].Value;
                string file = linkUrlMatch.Groups["file"].Value;
                if (Regex.IsMatch(host, HostFilter) && Regex.IsMatch(file, FileFilter)
                  && !urls.Contains(linkUrl))
                {
                    urls.Add(linkUrl,false);
                }
            }
        }

        public string FixUrl(string linkUrl,string url)
        {
            if (linkUrl.Contains("://"))
            { //完整路径
                return linkUrl;
            }
            if (linkUrl.StartsWith("//"))
            {
                Match urlMatch = Regex.Match(url, parseRef);
                string protocal = urlMatch.Groups["protocal"].Value;
                return protocal + ":" + linkUrl;
            }
            if (linkUrl.StartsWith("/"))
            {
                Match urlMatch = Regex.Match(url, parseRef);
                String site = urlMatch.Groups["site"].Value;
                return site.EndsWith("/") ? site + linkUrl.Substring(1) : site + linkUrl;
            }

            if (linkUrl.StartsWith("../"))
            {
                linkUrl = linkUrl.Substring(3);
                int idx = url.LastIndexOf('/');
                return FixUrl(linkUrl, url.Substring(0, idx));
            }

            if (linkUrl.StartsWith("./"))
            {
                return FixUrl(linkUrl.Substring(2), url);
            }
            
            int end = url.LastIndexOf("/");
            return url.Substring(0, end) + "/" + linkUrl;
        }
    }
}

