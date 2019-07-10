using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<string> CrawlingUrl(string url)
        {
            ObservableCollection<string> result=new ObservableCollection<string>();
            if (!CheckUrl(url)) //check url have http or https
            {
                url = "http://" + url;
            }

            HtmlWeb htmlWeb = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = htmlWeb.Load(url);
            HtmlNode bodyNode = document.DocumentNode.SelectSingleNode("//body");
            if (bodyNode != null)
            {
                string src = "";
                HtmlNodeCollection imgNods = document.DocumentNode.SelectNodes("//img");
                foreach(HtmlNode htmlNode in imgNods)
                {
                    try
                    {
                        src = htmlNode.Attributes["src"].Value;
                    }
                    catch
                    {
                        continue;
                    }
                    if (src != null && src!="")
                    {
                        result.Add(src);
                    }
                    
                }
            }
            return result;
        }
    }
}
