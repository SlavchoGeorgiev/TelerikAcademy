using System;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string strExample = "Test 123 :)";
            Console.WriteLine(strExample);
            Console.WriteLine(Reverse(strExample));
        }
        public static string Reverse(string inputStr)
        {
            char[] strLikeCharrArr = inputStr.ToCharArray();
            Array.Reverse(strLikeCharrArr);
            return new String(strLikeCharrArr);
        }
    }
}
