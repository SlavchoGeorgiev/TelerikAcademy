using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthPad
{
    class StringLengthPad
    {
        static void Main()
        {
            Console.Write("Please input string, smaler than 20 chars:");
            string inputStr = Console.ReadLine();
            inputStr = inputStr.PadLeft(20, '*');
            Console.WriteLine(inputStr);
        }
    }
}
