using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YoutubeRssFeedParse
{
    class EntryPoint
    {
        static void Main()
        {
            string telerikAcademyRssFeedUrl = "https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw";
            string rssFileUrl = "../../TARss.xml";
            string htmlFileUrl = "../../TARss.html";

            using (var webClient = new WebClient())
            {
                webClient.DownloadFile(telerikAcademyRssFeedUrl, rssFileUrl);
            }

            string rssFileContent;
            using (var reader = new StreamReader(rssFileUrl))
            {
                rssFileContent = reader.ReadToEnd();
            }

            XDocument xmlDoc = XDocument.Parse(rssFileContent);
            string rssAsJson = JsonConvert.SerializeXNode(xmlDoc, Formatting.Indented);
            JObject rssAsJObject = JObject.Parse(rssAsJson);
            var videoEntrys = rssAsJObject["feed"]["entry"];

            var listOfVideos = videoEntrys.Select(video => JsonConvert.DeserializeObject<Video>(video.ToString()))
                .ToList();

            //Console.WriteLine(rssAsJson);

            var htmlGenerator = new HtmlGeneratot();

            htmlGenerator.GenerateHtml(listOfVideos);
            htmlGenerator.SaveToFile(htmlFileUrl);
            Console.WriteLine("HTML Created!");
            //foreach (var video in listOfVideos)
            //{
            //    Console.WriteLine("Title: {0}", video.Link.Href);
            //}
        }
    }
}
