using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class LineNumbers
{
    static void Main()
    {
        string filePath = @"..\..\Text.txt";
        StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding(1251));
        string fileName = @"..\..\result.txt";
        StreamWriter resultFile = new StreamWriter(fileName, false, Encoding.GetEncoding(1251));
        StringBuilder resultText = new StringBuilder();
        using (reader)
        {
            int linenumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                linenumber++;
                resultText.Append(linenumber);
                resultText.Append(" : ");
                resultText.Append(line);
                resultText.Append(Environment.NewLine);
                line = reader.ReadLine();
            }
        }
        using (resultFile)
        {
            resultFile.Write(resultText);
            Console.WriteLine("SUCCESSFUL");
        }

    }
}