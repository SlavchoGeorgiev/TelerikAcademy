namespace OccurrencesOfDouble
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            double[] input =  {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5};
            Dictionary<double, int> valuesCounts = new Dictionary<double, int>();

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
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
