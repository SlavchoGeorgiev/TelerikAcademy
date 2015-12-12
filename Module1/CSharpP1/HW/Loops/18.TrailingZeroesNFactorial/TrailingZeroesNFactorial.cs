using System;
using System.Numerics;
//Problem 18.* Trailing Zeroes in N!
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end.
//Your program should work well for very big numbers, e.g. n=100000.
class TrailingZeroesNFactorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int trailingZeros = 0;
        BigInteger nFactorial = 1;
        for (int i = 2; i <= n; i++)
        {
            nFactorial = nFactorial * i;
        }
        while (nFactorial % 10 == 0)
        {
            if (nFactorial % 10 == 0)
            {
                trailingZeros++;
            }
            nFactorial = nFactorial / 10;
        }
        Console.WriteLine("Trailing zeroes : {0}", trailingZeros);
    }
}
