using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeRssFeedParse
{
    class HtmlGeneratot
    {
        private const string VideoItemTemplate = "<li><a href=\"{1}\">{0}</a></li>";

        public HtmlGeneratot()
        {
            this.Html = "";
        }

        private string Html { get; set; }
        public void GenerateHtml(IList<Video> videos)
        {
            var sr = new StringBuilder();

            sr.AppendLine("<ul>");

            foreach (var video in videos)
            {
                sr.AppendLine(string.Format(HtmlGeneratot.VideoItemTemplate, video.Title, video.Link.Href));
            }

            sr.AppendLine("</ul>");

            this.Html = sr.ToString();
        }

        public void SaveToFile(string url)
        {
            using (var stream = new FileStream(url, FileMode.Create))
            {
                using (var sw = new StreamWriter(stream, Encoding.UTF8))
                {
                    sw.Write(this.Html);
                }
            }
        }
    }
}
