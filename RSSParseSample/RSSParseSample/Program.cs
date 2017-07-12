using System.Collections.Generic;
using System.Xml.Linq;

namespace RSSParseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string RssFeedUrl = "http://rss.nytimes.com/services/xml/rss/nyt/HomePage.xml";
            List<RssItem> rssItems = new List<RssItem>();
            XDocument xDoc = new XDocument();
            xDoc = XDocument.Load(RssFeedUrl);
            var tempItems = xDoc.Descendants("item");
            foreach (var item in tempItems)
            {
                var rssItem = new RssItem();
                rssItem.Title = item.Element("title").Value;
                rssItem.Link = item.Element("link").Value;
                rssItem.Description = item.Element("description").Value;
                rssItems.Add(rssItem);
            }
        }

        class RssItem
        {
            public string Title { get; set; }
            public string Link { get; set; }
            public string Description { get; set; }
        }
    }
}
