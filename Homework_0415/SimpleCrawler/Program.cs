using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleCrawler
{
    public delegate void OutputHandler(object sender, OutputEventArgs e);
    public class OutputEventArgs: EventArgs
    {
        public string output { get; set; } = "";
        public OutputEventArgs(string output)
        {
            this.output = output;
        }
    }

    public class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public string startUrl { set; get; }
        private bool onlySpecified = false;
        //public string output { get; set; } = "";

        public event OutputHandler OnOutput;

        public SimpleCrawler() 
        {
            startUrl = "http://www.cnblogs.com/dstang2000/";
        }

        public SimpleCrawler(bool isSpecified, string url = "http://www.cnblogs.com/dstang2000/")
        {
            this.startUrl = url;
            this.onlySpecified = isSpecified;
        }


        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
            //myCrawler.startUrl = "http://www.cnblogs.com/dstang2000/";
            //if (args.Length >= 1) myCrawler.startUrl = args[0];
            myCrawler.urls.Add(myCrawler.startUrl, false); //加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        public void StartCrawl()
        {
            if (this.startUrl == "")
                throw new Exception("起始url错误");
            this.urls.Add(this.startUrl, false); //加入初始页面
            new Thread(this.Crawl).Start();
        }

        private void Crawl()
        {
            //Console.WriteLine("开始爬行了.... ");
            OnOutput(this, new OutputEventArgs("开始爬行了.... \n"));
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool) urls[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;
                //Console.WriteLine("爬行" + current + "页面!");
                OnOutput(this, new OutputEventArgs("爬行" + current + "页面!\n"));
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html); //解析,并加入新的链接
                //Console.WriteLine("爬行结束");
                OnOutput(this, new OutputEventArgs("爬行结束\n"));


            }
        }

        public string DownLoad(string url)
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

        private void Parse(string html)
        {
            // 完整路径处理
            // 是否只在本站爬取
            string strRef = "";
            if (onlySpecified)
            {
                strRef = @"(href|HREF)[]*=[]*[""']" + startUrl + @"[^""'#>]+[""']";
            }
            else 
                strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection absoluteMatches = new Regex(strRef).Matches(html);

            

            foreach (Match match in absoluteMatches)
            {
                // match.Value里面的是符合上面正则表达式的html网址，然后在里面找一个=，取=后面的字符为字串，再去除下面四种字符
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');

                //不是指定结尾直接跳过
                if (!strRef.EndsWith("html") && !strRef.EndsWith("aspx") && !strRef.EndsWith("jsp"))
                    continue;
                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }


            // 相对路径处理
            List<string> relativeToAbsoluteRrls = new List<string>();
            Uri baseUri = new Uri(startUrl);

            strRef = @"(href|HREF)[]*=[]*[""']./[^""'#>]+[""']";
            MatchCollection relativeMatches1 = new Regex(strRef).Matches(html);
            foreach(Match match in relativeMatches1)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                Uri absoluteUri = new Uri(baseUri, strRef);
                relativeToAbsoluteRrls.Add(absoluteUri.ToString());
            }

            strRef = @"(href|HREF)[]*=[]*[""']../[^""'#>]+[""']";
            MatchCollection relativeMatches2 = new Regex(strRef).Matches(html);
            foreach (Match match in relativeMatches2)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                Uri absoluteUri = new Uri(baseUri, strRef);
                relativeToAbsoluteRrls.Add(absoluteUri.ToString());
            }

            strRef = @"(href|HREF)[]*=[]*[""']/[^""'#>]+[""']";
            MatchCollection relativeMatches3 = new Regex(strRef).Matches(html);
            foreach (Match match in relativeMatches3)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                    .Trim('"', '\"', '#', '>');
                Uri absoluteUri = new Uri(baseUri, strRef);
                relativeToAbsoluteRrls.Add(absoluteUri.ToString());
            }

            foreach(string url in relativeToAbsoluteRrls)
            {
                if (!url.EndsWith("html") && !url.EndsWith("aspx") && !url.EndsWith("jsp"))
                    continue;
                if (url.Length == 0) continue;
                if (urls[url] == null) urls[url] = false;
            }
        }
    }
}
