using System;
/*
 * Problem 8. Prime Number Check
 * Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 */
class IsPrime
{
    static void Main()
    {
        Console.Write("Enter number n (1 <= n <= 100): ");
        sbyte n = sbyte.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine(false);
            return;
        }
        bool check = true;
        if (n == 0 || n == 1)
        {
            check = false;
        }
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                check = false;
            }
        }
        Console.WriteLine(check);
        //if (check)
        //{
        //    Console.WriteLine("{0} is prime", n);
        //}
        //else
        //{
        //    Console.WriteLine("{0} is not prime", n);
        //}
    }
}