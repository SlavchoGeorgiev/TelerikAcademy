namespace _07.ElementsWithEqualValueCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine(new string('-', 50));
            CountElementWithEqualValues(array);
        }

        public static void CountElementWithEqualValues(int[] array)
        {
            var occuraenceCounter = new Dictionary<int, int>();

            foreach (var number in array)
            {
                if (!occuraenceCounter.ContainsKey(number))
                {
                    occuraenceCounter[number] = 0;
                }

                occuraenceCounter[number]++;
            }

            var keys = occuraenceCounter.Keys.OrderBy(n => n);

            foreach (var key in keys)
            {
                Console.WriteLine("{0} → {1} times", key, occuraenceCounter[key]);
            }
        }
    }
}
