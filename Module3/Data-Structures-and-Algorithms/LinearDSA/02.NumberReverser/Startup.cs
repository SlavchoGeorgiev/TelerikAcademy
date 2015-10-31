namespace _02.NumberReverser
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("Please enter number of integers: ");
            var integersNumber = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < integersNumber; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }

            var sb = new StringBuilder();
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());
                sb.Append(", ");
            }

            Console.WriteLine(sb.ToString().Substring(0, sb.Length - 2));
        }
    }
}
