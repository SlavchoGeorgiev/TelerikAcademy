namespace VariationsOfSubSet
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            GenerateVariations(3, 2, new string[] { "hi", "a", "b"});
        }

        private static void GenerateVariations(int n, int k, string[] set, int index = 0, string[] result = null)
        {
            if (result == null)
            {
                result = new string[k];
            }

            if (index == k)
            {
                Console.WriteLine("{{{0}}}", string.Join(" ", result));
                return;
            }

            for (int i = 0; i < n; i++)
            {
                result[index] = set[i];
                GenerateVariations(3, 2, set, index + 1, result);
            }

        }
    }
}
