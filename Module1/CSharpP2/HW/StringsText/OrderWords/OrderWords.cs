using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            string words = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            Console.WriteLine(words);
            Console.WriteLine();
            string[] wordsAsArr = words.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Sort(wordsAsArr);
            StringBuilder sb = new StringBuilder();
            foreach (var word in wordsAsArr)
            {
                sb.Append(word);
                sb.Append(" ");
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine();
        }
    }
}
