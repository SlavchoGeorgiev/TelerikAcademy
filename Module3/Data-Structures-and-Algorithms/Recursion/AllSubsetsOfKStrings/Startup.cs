namespace AllSubsetsOfKStrings
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            GenerateAllSubsetsOfKStrings(2, new string[] {"test", "rock", "fun"});
        }

        private static void GenerateAllSubsetsOfKStrings(int k, string[] set)
        {
            GenerateAllSubsetsOfKStrings(k, set, 0, (1 << set.Length) - 1, new string[k]);
        }

        private static void GenerateAllSubsetsOfKStrings(int k, string[] set, int index, int mask, string[] result)
        {
            if (k == index)
            {
                Console.WriteLine("({0})", string.Join(" ", result));
                return;
            }

            for (int i = 0; i < set.Length; i++)
            {
                if ((mask & (1 << i)) != 0)
                {
                    result[index] = set[i];
                    GenerateAllSubsetsOfKStrings(k, set, index + 1, mask ^ (1 << i), result);
                    mask = mask ^ (1 << i);
                }
            }
        }
    }
}
