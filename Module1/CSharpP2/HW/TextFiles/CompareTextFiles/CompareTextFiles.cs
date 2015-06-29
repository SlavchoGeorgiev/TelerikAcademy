using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string firstFilePath = @"..\..\File1.txt";
        string secondFilePath = @"..\..\File2.txt";
        StreamReader readerfirstFile = new StreamReader(firstFilePath, Encoding.GetEncoding(1251));
        StreamReader readersecondFile = new StreamReader(secondFilePath, Encoding.GetEncoding(1251));
        int counter = 0;
        int counterDiferent = 0;
        using (readerfirstFile)
        {
            string lineFirstFile = readerfirstFile.ReadLine();
            string lineSecondFile = readersecondFile.ReadLine();
            while (lineSecondFile != null)
            {
                if (lineFirstFile.CompareTo(lineSecondFile) == 0)
                {
                    counter++;
                }
                else
                {
                    counterDiferent++;
                }
                lineFirstFile = readerfirstFile.ReadLine();
                lineSecondFile = readersecondFile.ReadLine();
            }
        }
        Console.WriteLine("Same = {0}",counter);
        Console.WriteLine("Different = {0}",counterDiferent);
    }
}
