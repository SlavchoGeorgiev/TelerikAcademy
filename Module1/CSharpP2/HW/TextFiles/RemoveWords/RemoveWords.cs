using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class RemoveWords
{
    static void Main()
    {
        StreamReader textFile = new StreamReader(@"..\..\text.txt", Encoding.GetEncoding(1251));
        StreamReader wordsFile = new StreamReader(@"..\..\words.txt", Encoding.GetEncoding(1251));
        StreamWriter resultFile = new StreamWriter(@"..\..\result.txt", false, Encoding.GetEncoding(1251));
        StringBuilder text = new StringBuilder();
        string output = string.Empty;
        try
        {
            using (textFile)
            {
                string line = textFile.ReadLine();
                while (line != null)
                {
                    text.Append(line);
                    text.Append(Environment.NewLine);
                    line = textFile.ReadLine();
                }
            }
            Console.WriteLine(text);
            string[] word = wordsFile.ReadToEnd().Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';','\n','\t','\r' }, StringSplitOptions.RemoveEmptyEntries);
            wordsFile.Close();
            
            output = text.ToString();
            for (int i = 0; i < word.Length; i++)
            {
                output = Regex.Replace(output, word[i], "");
            }
            using (resultFile)
            {
                resultFile.Write(output);
                Console.WriteLine("Result SUCCESSFUL");
            }
        }
        catch (ArgumentNullException ane)
        {
            Console.WriteLine(ane.Message);
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        catch (ArgumentException ae)
        {
            Console.WriteLine(ae.Message);
        }
        catch (NotSupportedException nse)
        {
            Console.WriteLine(nse.Message);
        }
        catch (IOException io)
        {
            Console.WriteLine(io.Message);
        }
    }
}
