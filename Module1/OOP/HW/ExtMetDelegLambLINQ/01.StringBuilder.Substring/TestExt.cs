namespace _01.StringBuilderSubstring
{
    using System;
    using System.Text;

    class TestExt
    {
        static void Main()
        {
            var testSB = new StringBuilder("Some text for test.");
            Console.WriteLine(testSB);
            Console.WriteLine("Substring:" + testSB.Substring(5, 4));
        }
    }
}
