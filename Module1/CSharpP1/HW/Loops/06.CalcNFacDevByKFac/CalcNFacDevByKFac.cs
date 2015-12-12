using System;
//Problem 6. Calculate N! / K!
//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
class CalcNFacDevByKFac
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int factorialNK = 1;
        for (int i = k + 1; i <= n; i++)
        {
            factorialNK = factorialNK * i;
        }
        Console.WriteLine(factorialNK);
    }
}