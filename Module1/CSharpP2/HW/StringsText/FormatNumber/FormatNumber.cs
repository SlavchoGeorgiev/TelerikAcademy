using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatNumber
{
    class FormatNumber
    {
        static void Main()
        {
            string testNumber = "123123";
            //string testNumber = Console.ReadLine();
            Console.WriteLine(ToDec(testNumber));
            Console.WriteLine(ToHex(testNumber));
            Console.WriteLine(ToPercentage(testNumber));
            Console.WriteLine(ToScientificNotation(testNumber));
        }
        static string ToScientificNotation(string number)
        {
            return String.Format("{0,15:E}", number);
        }

        static string ToPercentage(string number)
        {
            return String.Format("{0,15:P}", double.Parse(number) / 100);
        }

        static string ToHex(string number)
        {
            return String.Format("{0,15:X}", int.Parse(number));
        }

        static string ToDec(string number)
        {
            return String.Format("{0,15:D}", int.Parse(number));
        }
    }
}
