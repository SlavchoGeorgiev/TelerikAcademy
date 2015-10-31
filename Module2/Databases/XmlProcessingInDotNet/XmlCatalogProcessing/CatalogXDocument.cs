using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlCatalogProcessing
{
    public class CatalogXDocument
    {
        public CatalogXDocument(string catalogUrl)
        {
            this.CatalogUrl = catalogUrl;
        }

        public string CatalogUrl { get; set; }

        public IEnumerable<string> FindAllSongsTitles()
        {
            XDocument xmlDocument = XDocument.Load(this.CatalogUrl);
            var songsList = xmlDocument.Descendants("title").Select(n => n.Value.Trim());

            return songsList;
        }
    }
}
