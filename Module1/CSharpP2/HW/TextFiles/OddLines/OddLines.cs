using System;
using System.Text;
using System.IO;


class OddLines
{
    static void Main()
    {
        string fileName = @"..\..\Text.txt";
        StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding(1251));
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
    }
}
