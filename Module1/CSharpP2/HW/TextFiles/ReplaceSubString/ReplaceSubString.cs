using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;


class ReplaceSubString
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader( @"..\..\input.txt", Encoding.GetEncoding(1251));
        StreamWriter resultFile = new StreamWriter(@"..\..\result.txt", false, Encoding.GetEncoding(1251));

        StringBuilder resultText = new StringBuilder();
        using (inputFile)
        {
            string line = inputFile.ReadLine();
            while (line != null)
            {
                resultText.Append(line);
                resultText.Append(Environment.NewLine);
                line = inputFile.ReadLine();
            }

        }
        string output = string.Empty ;
        output = Regex.Replace(resultText.ToString(),"start", "finish");
        using (resultFile)
        {
            resultFile.Write(output);
            Console.WriteLine("SUCCESSFUL");
        }
    }
}
