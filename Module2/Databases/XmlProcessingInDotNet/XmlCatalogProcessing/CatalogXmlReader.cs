using System.Collections.Generic;
using System.Xml;

namespace XmlCatalogProcessing
{
    public class CatalogXmlReader
    {
        public CatalogXmlReader(string catalogUrl)
        {
            this.CatalogUrl = catalogUrl;
        }

        private string CatalogUrl { get; set; }

        public IEnumerable<string> FindAllSongsTitles()
        {
            var songsList = new List<string>();

            using (XmlReader reader = new XmlTextReader(this.CatalogUrl))
            {
                while (reader.Read())
                {
                    if (reader.Name == "title")
                    {
                        songsList.Add(reader.ReadElementContentAsString());
                    }
                }
            }

            return songsList;
        }
    }
}