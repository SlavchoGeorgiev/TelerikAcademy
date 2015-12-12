namespace CombinationsWithDuplicates
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            PrintCombinationsWithDublicates(3, 2);
        }

        private static void PrintCombinationsWithDublicates(int n, int k, Stack<int> stack = null )
        {
            if (stack == null)
            {
                stack = new Stack<int>();
            }

            if (k == 0)
            {
                Console.WriteLine("({0})", string.Join(", ", stack));
                return;
            }

            for (int i = 1; i <= n; i++)
            {
                stack.Push(i);
                PrintCombinationsWithDublicates(i, k - 1, stack);
                stack.Pop();
            }
        }
    }
}
