using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = "aaaaabbbbbcdddeeeedssaa";
            StringBuilder sb = new StringBuilder(input);
            for (int i = 0; i < sb.Length; i++)
            {
                if (i + 1 < sb.Length)
                {
                    if (sb[i] == sb[i + 1])
                    {
                        sb.Remove(i + 1, 1);
                        i--;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
