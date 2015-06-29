using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class SaveSortedNames
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.GetEncoding(1251);
        StreamReader reader = new StreamReader(@"..\..\input.txt", Encoding.GetEncoding(1251));
        StreamWriter writer = new StreamWriter(@"..\..\output.txt",false,Encoding.GetEncoding(1251));
        List<string> list = new List<string>();

        using (reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                list.Add(line);
                line = reader.ReadLine();
            }
        }
        list.Sort();
        using (writer)
        {
            for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i]);
                Console.WriteLine(list[i]);
            }
            
        }

    }
}
