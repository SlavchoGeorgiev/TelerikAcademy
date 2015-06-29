using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            string inputStr = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string badWord = "PHP, CLR, Microsoft";
            Console.WriteLine(inputStr);
            Console.WriteLine(Censurate(inputStr, badWord));
        }
        public static string Censurate(string text, string badWords)
        {
            StringBuilder sb = new StringBuilder(text);
            string[] badWordArr = badWords.Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries );
            foreach (var word in badWordArr)
            {
                sb.Replace(word, new String('*', word.Length));
            }
            return sb.ToString();
        }
    }
}
