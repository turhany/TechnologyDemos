using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace HtmlParseSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri url = new Uri("http://www.ntv.com.tr/tv/yayin-akisi/");
            WebClient webclient = new WebClient();
            webclient.Encoding = Encoding.UTF8;
            string html = webclient.DownloadString(url);
            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var programList = htmlDocument.DocumentNode.Descendants("ul")
                .Single(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Equals("programmes"))
                .SelectNodes("li");

            var channel = new Channel();
            channel.Name = "NTV";
            foreach (var program in programList)
            {
                var channelProgram = new ChannelProgram();
                channelProgram.Time = program.SelectSingleNode("a").Descendants("span")
                    .Single(d => d.Attributes.Contains("class") && d.Attributes["class"]
                                     .Value.Equals("tv-hour")).InnerText;

                channelProgram.Name = program.SelectSingleNode("a").Descendants("span")
                    .Single(d => d.Attributes.Contains("class") && d.Attributes["class"]
                                     .Value.Equals("programmeTitle")).InnerText.Replace("\r", "");

                channel.Programs.Add(channelProgram);
            }

            foreach (var item in channel.Programs)
            {
                Console.WriteLine(item.Name + " " + item.Time);
            }
            Console.ReadKey();
        }

        class ChannelProgram
        {
            public string Name { get; set; }
            public string Time { get; set; }
        }

        class Channel
        {
            public string Name { get; set; }
            public List<ChannelProgram> Programs { get; set; }
            public Channel()
            {
                this.Programs = new List<ChannelProgram>();
            }
        }
    }
}
