using System;
using System.Numerics;
//Problem 8. Catalan Numbers
//In combinatorics, the Catalan numbers are calculated by catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger doubleNFactDevByNFac = 1;
        BigInteger nPlusOneFac = 1;
        for (int i = n + 1; i <= 2 * n; i++)
        {
            doubleNFactDevByNFac = doubleNFactDevByNFac * i;
        }
        for (int i = 2; i <= n + 1; i++)
        {
            nPlusOneFac = nPlusOneFac * i;
        }
        BigInteger catalan = doubleNFactDevByNFac / nPlusOneFac;
        Console.WriteLine(catalan);
    }
}
