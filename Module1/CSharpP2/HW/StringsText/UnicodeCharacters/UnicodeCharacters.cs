using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("To Unicode: {0}", ToUnicode(input));
        }
        private static string ToUnicode(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var letter in input)
            {
                sb.Append(String.Format("\\u{0:X4}", (int)letter));
            }

            return sb.ToString();
        }
    }
}
