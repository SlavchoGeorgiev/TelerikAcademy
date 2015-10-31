using Newtonsoft.Json;

namespace YoutubeRssFeedParse
{
    public class Video
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        
        public  Link Link { get; set; }
        public override string ToString()
        {
            return this.Title;
        }
    }
}
