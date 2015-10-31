namespace _10.ShortestSequence
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sequence = GenerateShortestSequence(5, 16);

            while (sequence.Count > 0)
            {
                Console.Write("{0} ", sequence.Pop());
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 50));

            var bigSequence = GenerateShortestSequence(5, 233);

            while (bigSequence.Count > 0)
            {
                Console.Write("{0} ", bigSequence.Pop());
            }
        }

        public static Stack<int> GenerateShortestSequence(int n, int m)
        {
            var result = new Stack<int>();
            result.Push(m);

            while (true)
            {
                var currentValue = result.Peek();

                if (currentValue == n)
                {
                    return result;
                }

                if (currentValue % 2 == 0 && currentValue / 2 >= n)
                {
                    result.Push(currentValue / 2);
                }
                else if ((currentValue - 1) / 2 >= n)
                {
                    result.Push(currentValue - 1);
                }
                else if (currentValue - 2 >= n)
                {
                    result.Push(currentValue - 2);
                }
                else
                {
                    result.Push(currentValue - 1);
                }
            }
        } 
    }
}
