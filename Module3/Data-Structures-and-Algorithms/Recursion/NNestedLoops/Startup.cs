namespace NNestedLoops
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());

            PrintN(n, n);
        }

        private static void PrintN(int n, int maxDepth, int depth = 0, Stack<int> stack = null)
        {
            if (stack == null)
            {
                stack = new Stack<int>();
            }

            if (maxDepth == depth)
            {
                Console.WriteLine(string.Join(" ", stack.Reverse()));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                stack.Push(i);
                PrintN(n, maxDepth, depth + 1, stack);
                stack.Pop();
            }
        }
    }
}
