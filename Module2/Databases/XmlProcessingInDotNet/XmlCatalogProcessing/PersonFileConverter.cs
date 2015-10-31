using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlCatalogProcessing
{
    public class PersonFileConverter
    {
        public void TextToXml(string txtUrl, string xmlUrl)
        {
            XmlDocument doc = new XmlDocument();

            XmlElement xmlRoot = doc.CreateElement("persons");
            doc.AppendChild(doc.CreateXmlDeclaration("1.0", "utf-8", ""));
            doc.AppendChild(xmlRoot);
            
            using (var reader = new StreamReader(txtUrl))
            {
                var currentLine = reader.ReadLine();
                while (currentLine != null)
                {
                    var currentLineAsArray = currentLine.Split(';');

                    var personNode = doc.CreateElement("person");
                    var personName = doc.CreateElement("name");
                    var personAddress = doc.CreateElement("address");
                    var personPhone = doc.CreateElement("phone");

                    personNode.AppendChild(personName);
                    personNode.AppendChild(personAddress);
                    personNode.AppendChild(personPhone);

                    personName.AppendChild(doc.CreateTextNode(currentLineAsArray[0].Trim()));
                    personAddress.AppendChild(doc.CreateTextNode(currentLineAsArray[1].Trim()));
                    personPhone.AppendChild(doc.CreateTextNode(currentLineAsArray[2].Trim()));

                    xmlRoot.AppendChild(personNode);

                    currentLine = reader.ReadLine();
                }
            }

            doc.Save(xmlUrl);

            Console.WriteLine(new String('-', 50));
            Console.WriteLine("Text file converted to person XML format");
            Console.WriteLine(new String('-', 50));
        }
    }
}
