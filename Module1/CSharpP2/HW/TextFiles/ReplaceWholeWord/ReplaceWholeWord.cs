using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

class ReplaceWholeWord
{
    static void Main()
    {
        StreamReader inputFile = new StreamReader(@"..\..\input.txt", Encoding.GetEncoding(1251));
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
        string output = string.Empty;
        Console.WriteLine(resultText);
        output = Regex.Replace(resultText.ToString(), @"(\s)start(\s)", "finish");
        output = Regex.Replace(resultText.ToString(), @"(\b)start(\b)", "finish");
        Console.WriteLine(output);
        using (resultFile)
        {
            resultFile.Write(output);
            Console.WriteLine("Result SUCCESSFUL");
        }
    }
}
