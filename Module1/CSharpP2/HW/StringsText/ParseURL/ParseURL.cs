using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseURL
{
    class ParseURL
    {
        static void Main()
        {
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine("URL = {0}", url);
            string protocol = url.Substring(0, url.IndexOf("://"));
            Console.WriteLine("[protocol] = {0}", protocol);
            string server = url.Substring(url.IndexOf("://") + 3, url.IndexOf('/', url.IndexOf("://") + 3)  - url.IndexOf("://") - 3);
            Console.WriteLine("[server] = {0}", server);
            string resource = url.Substring(url.IndexOf('/', url.IndexOf("://") + 3));
            Console.WriteLine("[resourece] = {0}", resource);
        }
    }
}
