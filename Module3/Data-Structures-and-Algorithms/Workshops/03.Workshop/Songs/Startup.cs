namespace Songs
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static int[] sorted;

        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var array1 = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            var array2 = Console.ReadLine().Split(' ').Select(e => int.Parse(e)).ToArray();
            var rename = new int[n + 1];
            sorted = new int[n];

            for (int i = 0; i < n; i++)
            {
                rename[array1[i]] = i;
            }

            for (int i = 0; i < n; i++)
            {
                array2[i] = rename[array2[i]];
            }

            //long counter = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array2[i] > array2[j])
            //        {
            //            counter++;
            //        }
            //    }
            //}

            Console.WriteLine(CountInversions(array2, 0, n));
        }

        private static long CountInversions(int[] array, int left, int right)
        {
            if (left + 1 == right)
            {
                return 0;
            }

            int middle = (left + right) / 2;

            long inversions = CountInversions(array, left, middle) + CountInversions(array, middle, right);
            
            int i = left;
            int j = middle;
            int k = 0;

            while (i < middle && j < right)
            {
                if (array[i] < array[j])
                {
                    sorted[k] = array[i];
                    i++;
                }
                else
                {
                    inversions += middle - i;
                    sorted[k] = array[j];
                    j++;
                }

                k++;
            }

            while (i < middle)
            {
                sorted[k] = array[i];
                i++;
                k++;
            }

            while (j < right)
            {
                sorted[k] = array[j];
                j++;
                k++;
            }

            for (int l = 0; l < k; l++)
            {
                array[left + l] = sorted[l];
            }

            return inversions;
        }
    }
}
