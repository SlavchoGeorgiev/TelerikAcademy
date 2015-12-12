namespace Fibonacci
{
    using System;
    using System.Numerics;

    class Startup
    {
        static void Main()
        {
            var n = BigInteger.Parse(Console.ReadLine());
            int before = 1;
            int current = 1;

            if (n == 1 || n == 2)
            {
                Console.WriteLine(1);
            }
            else
            {
                int temp;
                for (BigInteger i = 2; i < n; i++)
                {
                    temp = current % 1000000007;
                    current = (current +  before) % 1000000007;
                    before = temp;
                }

                Console.WriteLine(current % 1000000007);
            }
        }
    }
}
