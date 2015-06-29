using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _04.DownloadFile
{
    class DownloadFile
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Content/Images/news-img01.png";
            string fileName = url.Substring(url.LastIndexOf('/') + 1, url.Length - url.LastIndexOf('/') - 1);
            WebClient wc = new WebClient();
            try
            {
                wc.DownloadFile(url, fileName);
            }
            catch (WebException we)
            {
                Console.WriteLine(we.Message);
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message);
            }
            catch (ArgumentNullException enx)
            {
                Console.WriteLine(enx.Message);
            }
            finally
            {
                Console.WriteLine("Successfully Downloaded File \"{0}\" \nfrom: \"{1}\"", fileName, url);
                wc.Dispose();
            }
        }
    }
}
