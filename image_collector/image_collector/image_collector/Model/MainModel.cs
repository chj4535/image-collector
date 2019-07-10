using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace image_collector.Model
{
    public class MainModel
    {
        Crawler crawler = new Crawler();
        public ObservableCollection<string> imgList { get; set; }
        public ObservableCollection<string> CrawlingUrl(string url)
        {
            return crawler.CrawlingUrl(url);
        }
    }
}
