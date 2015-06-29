using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadFileContents
{
    class ReadFileContents
    {
        static void Main()
        {
            string path = "C:\\WINDOWS\\win.ini";
            try
            {
                string readText = File.ReadAllText(path);
                Console.WriteLine(readText);
            }
            catch (ArgumentNullException arn)
            {
                Console.WriteLine(arn.Message); ;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); ;
            }
            catch (PathTooLongException pat)
            {
                Console.WriteLine(pat.Message); ;
            }
            catch (DirectoryNotFoundException dir)
            {
                Console.WriteLine(dir.Message); ;
            }
            catch (FileNotFoundException fil)
            {
                Console.WriteLine(fil.Message); ;
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message); ;
            }
            catch (UnauthorizedAccessException ua)
            {
                Console.WriteLine(ua.Message); ;
            }
            catch (NotSupportedException nse)
            {
                Console.WriteLine(nse.Message); ;
            }
            catch (SecurityException se)
            {
                Console.WriteLine(se.Message); ;
            }
        }
    }
}
