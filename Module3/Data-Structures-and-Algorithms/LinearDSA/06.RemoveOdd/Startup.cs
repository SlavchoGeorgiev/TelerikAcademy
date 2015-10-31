namespace _06.RemoveOdd
{
    using System;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var testList = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Console.WriteLine(string.Join(", ", testList));
            RemoveOddNumberOccuraence(testList);
            Console.WriteLine(new string('-', 30));
            Console.WriteLine(string.Join(", ", testList));
        }

        public static List<int> RemoveOddNumberOccuraence(List<int> list)
        {
            var occuraenceCounter = new Dictionary<int, int>();

            foreach (var number in list)
            {
                if (!occuraenceCounter.ContainsKey(number))
                {
                    occuraenceCounter[number] = 0;
                }

                occuraenceCounter[number]++;
            }

            foreach (var key in occuraenceCounter.Keys)
            {
                if (occuraenceCounter[key] % 2 != 0)
                {
                    list.RemoveAll(n => n == key);
                }
            }

            return list;
        }
    }
}
