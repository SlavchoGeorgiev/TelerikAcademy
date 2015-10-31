using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XmlCatalogProcessing;

namespace CatalogExecutor
{
    class EntryPoint
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;

            var xmlUrl = "../../catalog.xml";

            var domCatalogParser = new CatalogDOMParser(xmlUrl);

            IEnumerable<string> artists = domCatalogParser.FindAllArtists();

            foreach (var artist in artists)
            {
                Console.WriteLine("{0} has {1} albums in this catalog (With DOM)", artist, domCatalogParser.FindArtistAlbumsCount(artist));
                Console.WriteLine("{0} has {1} albums in this catalog (With XPath)", artist, domCatalogParser.FindArtistAlbumsCountWithXPath(artist));
            }

            domCatalogParser.DeleteAllAlbumsWithPriceBiggerThan(20, "../../catalogAftherDelete.xml");
            Console.WriteLine();
            Console.WriteLine("Albums with price bigger than 20 deleted and saved in file catalogAftherDelete.xml.");

            var xmlCatalogReader = new CatalogXmlReader(xmlUrl);
            var songColection = xmlCatalogReader.FindAllSongsTitles();

            Console.WriteLine();
            Console.WriteLine("All songs found with XmlReader:");
            var songNumber = 1;
            foreach (var songTitle in songColection)
            {
                Console.WriteLine("{0}. {1}", songNumber++, songTitle);
            }

            var xCatalog = new CatalogXDocument(xmlUrl);
            var songColectionFromXDocument = xCatalog.FindAllSongsTitles();

            Console.WriteLine();
            Console.WriteLine("All songs found with XDocument:");
            songNumber = 1;
            foreach (var songTitle in songColectionFromXDocument)
            {
                Console.WriteLine("{0}. {1}", songNumber++, songTitle);
            }

            var personTextFileUrl = "../../persons.txt";
            var personXmlFileUrl = "../../persons.xml";
            PersonFileConverter personFL = new PersonFileConverter();

            personFL.TextToXml(personTextFileUrl, personXmlFileUrl);
        }
    }
}
