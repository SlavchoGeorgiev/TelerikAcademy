using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class DeleteOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\Text.txt", Encoding.GetEncoding(1251));
        StringBuilder result = new StringBuilder();
        try
        {
            using (reader)
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                        result.Append(line);
                        result.Append(Environment.NewLine);
                    }
                    line = reader.ReadLine();
                }
            }
            
        }
        catch (FileNotFoundException fnfe)
        {
            Console.WriteLine(fnfe.Message);
        }
        catch (DirectoryNotFoundException dnfe)
        {
            Console.WriteLine(dnfe.Message);
        }
        StreamWriter writer = new StreamWriter(@"..\..\Text.txt", false, Encoding.GetEncoding(1251));
        using (writer)
        {
            writer.WriteLine(result);
        }

    }
}
