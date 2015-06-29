using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStrInText
{
    public class SubStrInText
    {
        static void Main()
        {
            string testStr = "We are living In an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string subStr = "In";
            Console.WriteLine("{0}", testStr);
            Console.WriteLine();
            Console.WriteLine("Substring \"{0}\" is conteining {1} times.", subStr, SubStrCounter(testStr, subStr));
        }
        public static int SubStrCounter(string inputStr, string subStr)
        {
            int nextStartIndex = 0;
            int counter = 0;
            while (inputStr.ToLower().IndexOf(subStr.ToLower(), nextStartIndex) >= 0)
            {
                nextStartIndex = inputStr.ToLower().IndexOf(subStr.ToLower(), nextStartIndex) + 1;
                counter++;
                if (nextStartIndex >= inputStr.Length)
                {
                    break;
                }
            }
            return counter;
        }
    }
}
