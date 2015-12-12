namespace BinaryTrees
{
    using System;
    using System.Collections.Generic;
    using System.Numerics;

    public class Startup
    {
        public static BigInteger[] memo;

        public static BigInteger Trees(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            if (memo[n] != 0)
            {
                return memo[n];
            }

            BigInteger result = 0;
            for (int i = 0; i < n; i++)
            {
                result += Trees(i) * Trees(n - 1 - i);
            }

            memo[n] = result;
            return result;
        }

        public static void Main()
        {
            var input = Console.ReadLine();
            var groups = new int[26];

            foreach (var c in input)
            {
                groups[c - 'A']++;
            }

            var n = input.Length;
            memo = new BigInteger[n + 1]; ;

            var factorials = new long[n + 1];
            factorials[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                factorials[i] = factorials[i - 1] * i;
            }

            long result = factorials[n];

            foreach (var x in groups)
            {
                result /= factorials[x];
            }

            Console.WriteLine(result * Trees(n));
        }
    }
}
