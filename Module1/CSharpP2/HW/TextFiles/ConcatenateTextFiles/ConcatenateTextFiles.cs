using System;
using System.IO;
using System.Text;

class ConcatenateTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\File1.txt";
        string secondFilePath = @"..\..\File2.txt";
        StreamReader firstFile = new StreamReader(firstFilePath, Encoding.GetEncoding(1251));
        StreamReader secondFile = new StreamReader(secondFilePath, Encoding.GetEncoding(1251));
        string fileName = @"..\..\result.txt";
        StreamWriter resultFile = new StreamWriter(fileName,false,Encoding.GetEncoding(1251));
        using (resultFile)
        {
            resultFile.WriteLine(firstFile.ReadToEnd());
            resultFile.WriteLine(secondFile.ReadToEnd());
            Console.WriteLine("Concatenated");
        }

    }
}
