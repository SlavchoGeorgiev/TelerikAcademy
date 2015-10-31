using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlCatalogProcessing
{
    public class CatalogDOMParser
    {
        public CatalogDOMParser(string catalogURL)
        {
            this.CatalogUrl = catalogURL;
            this.Document = new XmlDocument();
            Document.Load(this.CatalogUrl);
            this.XmlRoot = this.Document.DocumentElement;
        }

        private XmlDocument Document { get; set; }

        private XmlNode XmlRoot { get; set; }

        private string CatalogUrl { get; set; }

        public int FindArtistAlbumsCount(string authorName)
        {
            int albumCounter = 0;

            foreach (XmlNode album in XmlRoot.ChildNodes)
            {
                if (album["artist"].InnerText.Trim().ToLower() == authorName.Trim().ToLower())
                {
                    albumCounter++;
                }
            }

            return albumCounter;
        }

        public int FindArtistAlbumsCountWithXPath(string authorName)
        {
            string xPathQuery = "/catalog/album/artist[normalize-space(text()) = '" + authorName + "']";

            var result = Document.SelectNodes(xPathQuery).Count;
            return result;
        }

        public IEnumerable<string> FindAllArtists()
        {
            var listOfArtists = new List<string>();

            
            foreach (XmlNode album in XmlRoot.ChildNodes)
            {
                var currentArtist = album["artist"].InnerText.Trim();

                if (!listOfArtists.Contains(currentArtist))
                {
                    listOfArtists.Add(currentArtist);
                }
            }

            return listOfArtists;
        }

        public void DeleteAllAlbumsWithPriceBiggerThan(double price, string saveToUrl)
        {
            foreach (XmlNode album in XmlRoot.ChildNodes)
            {
                if (double.Parse(album["price"].InnerText) > price)
                {
                    XmlRoot.RemoveChild(album);
                }
            }

            Document.Save(saveToUrl);
        }
    }
}
