using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
using System.IO;

class PrefixTest
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\Text.txt", Encoding.GetEncoding(1251));
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
        Console.WriteLine(resultText);
        string output = string.Empty;
        output = Regex.Replace(resultText.ToString(), @"test(\w+)", " ");
        Console.WriteLine(output);
        using (resultFile)
        {
            resultFile.Write(output);
            Console.WriteLine("Result SUCCESSFUL");
        }
    }
}
