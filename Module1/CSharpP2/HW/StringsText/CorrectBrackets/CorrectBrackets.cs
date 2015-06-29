using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string testStr1 = "((a+b)/5-d)";
            string testStr2 = ")(a+b))";
            Console.WriteLine("{0} is {1}",testStr1, IsCorrectBrackets(testStr1) ? "correct" : "not correct");
            Console.WriteLine("{0} is {1}", testStr2, IsCorrectBrackets(testStr2) ? "correct" : "not correct");
        }
        public static bool IsCorrectBrackets(string inStr)
        {
            int bracketBalans = 0;
            foreach (var ch in inStr)
            {
                if (ch == '(')
                {
                    bracketBalans++;
                }
                if (ch == ')')
                {
                    bracketBalans--;
                }
            }
            if (bracketBalans == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
