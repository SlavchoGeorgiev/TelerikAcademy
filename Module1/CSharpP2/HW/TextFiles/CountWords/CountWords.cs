using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CountWords
{
    static void Main()
    {
        StreamReader textFile = new StreamReader(@"..\..\text.txt", Encoding.GetEncoding(1251));
        StreamReader wordsFile = new StreamReader(@"..\..\words.txt", Encoding.GetEncoding(1251));
        StreamWriter resultFile = new StreamWriter(@"..\..\result.txt", false, Encoding.GetEncoding(1251));
        StringBuilder text = new StringBuilder();
        string output = string.Empty;
        Dictionary<int , string> dictionary = new Dictionary<int,string>();
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
            
            string[] word = wordsFile.ReadToEnd().Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            wordsFile.Close();
            string[] textWords = text.ToString().Split(new char[] { ' ', ',', '!', '.', '?', ':', '-', '/', ';', '\n', '\t', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < word.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < textWords.Length; j++)
                {
                    if (string.Compare(word[i],textWords[j],false) == 0)
                    {
                        counter++;
                    }
                }
                dictionary.Add(counter, word[i]);
                counter = 0;
            }
            var list = dictionary.Keys.ToList();
            list.Sort();
            list.Reverse();

            using (resultFile)
            {
                foreach (var key in list)
                {
                    Console.WriteLine("{0}: {1}", key, dictionary[key]);
                    resultFile.WriteLine("{0}: {1}", key, dictionary[key]);
                }
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
