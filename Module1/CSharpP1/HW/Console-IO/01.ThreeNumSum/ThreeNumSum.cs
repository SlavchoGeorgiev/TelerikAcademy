using System;
using System.Globalization;
using System.Threading;
//Problem 1. Sum of 3 Numbers
//Write a program that reads 3 real numbers from the console and prints their sum
class ThreeNumSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b, c;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, a + b + c);
    }
}
