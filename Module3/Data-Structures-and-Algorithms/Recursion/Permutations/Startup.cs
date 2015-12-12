namespace Permutations
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            GeneratePermutations(3);
            // GeneratePermutations(1, 4, 0, new int[2], (1 << 4) - 1);
        }

        private static void GeneratePermutations(int n)
        {
            GeneratePermutations(1, n, 0, new int[n], (1 << n) - 1);
        }

        private static void GeneratePermutations(int begin, int end, int index, int[] array, long used)
        {
            if (index == array.Length)
            {
                Console.WriteLine("{{{0}}}", string.Join(", ", array));
                return;
            }

            for (int i = begin; i <= end; i++)
            {
                if ((used & (1 << (i - 1))) != 0)
                {
                    array[index] = i;
                    GeneratePermutations(begin, end, index + 1, array, used ^ (1 << (i - 1)));
                }
            }
        }
    }
}
