using System;
using System.Globalization;
using System.Threading;
//Problem 4. Number Comparer
//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.
class NumComparer
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double a, b;
        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.WriteLine("The bigger is : {0}", a < b ? b : a);
        Console.WriteLine("The bigger is : {0}", Math.Max(a, b));
    }
}