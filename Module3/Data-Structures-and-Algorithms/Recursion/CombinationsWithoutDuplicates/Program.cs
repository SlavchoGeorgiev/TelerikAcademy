namespace CombinationsWithoutDuplicates
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            PrintCombinationsWithoutDublicates(4, 2);
        }

        private static void PrintCombinationsWithoutDublicates(int end, int k, int begin = 1, Stack<int> stack = null)
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

            for (int i = begin; i <= end; i++)
            {
                stack.Push(i);
                PrintCombinationsWithoutDublicates(end, k - 1, i + 1, stack);
                stack.Pop();
            }
        }
    }
}
