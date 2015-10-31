namespace _08.Majorant
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            int[] testArray = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            Console.WriteLine(string.Join(", ", testArray));
            Console.WriteLine(new string('-', 50));
            PrintMajorand(testArray);
        }

        public static void PrintMajorand(int[] array)
        {
            var majorantMinCriteria = (array.Length / 2) + 1;

            var occuraenceCounter = new Dictionary<int, int>();

            foreach (var number in array)
            {
                if (!occuraenceCounter.ContainsKey(number))
                {
                    occuraenceCounter[number] = 0;
                }

                occuraenceCounter[number]++;
            }

            var keys = occuraenceCounter.Keys;

            foreach (var key in keys)
            {
                if (occuraenceCounter[key] >= majorantMinCriteria)
                {
                    Console.WriteLine("Majorant is: {0}", key);
                    return;
                }
            }

            Console.WriteLine("Majorand not found.");
        }
    }
}
