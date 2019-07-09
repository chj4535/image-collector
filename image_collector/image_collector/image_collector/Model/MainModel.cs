using System;
using System.Collections.Generic;
using System.Text;

namespace image_collector.Model
{
    public class MainModel
    {
        Crawler crawler = new Crawler();

        public string CrawlingUrl(string url)
        {
            return crawler.CrawlingUrl(url);
        }
    }
}
