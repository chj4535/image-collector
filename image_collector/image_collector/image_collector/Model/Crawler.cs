using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using HtmlAgilityPack;

namespace image_collector.Model
{
    public class Crawler
    {
        public bool CheckUrl(string url)
        {
            string urlHead = url.Split(':')[0];
            if(urlHead=="http" || urlHead == "https")
            {
                return true;
            }
            return false;
        }

        public string CrawlingUrl(string url)
        {
            if (!CheckUrl(url)) //check url have http or https
            {
                url = "http://" + url;
            }
            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;
            string siteSource = client.DownloadString(url);
            return siteSource;
        }
    }
}
