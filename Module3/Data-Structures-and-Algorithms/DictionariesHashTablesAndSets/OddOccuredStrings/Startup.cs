namespace OccurrencesOfDouble
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string[] input = {"C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            Dictionary<string, int> valuesCounts = new Dictionary<string, int>();

            foreach (var value in input)
            {
                if (!valuesCounts.Keys.Contains(value))
                {
                    valuesCounts[value] = 1;
                }
                else
                {
                    valuesCounts[value]++;
                }
            }

            foreach (var pair in valuesCounts)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}