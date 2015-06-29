using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            uint currDigit;
            int counter = 0;
            uint sum = 0;
            for (int i = 1; i < input.Length; i = i + 2)
            {
                if (uint.TryParse(input[i].ToString(), out currDigit))
                {
                    sum = sum + currDigit;
                    counter++;
                }
            }
            Console.WriteLine("{0} {1}", counter, sum);
        }
    }
}
