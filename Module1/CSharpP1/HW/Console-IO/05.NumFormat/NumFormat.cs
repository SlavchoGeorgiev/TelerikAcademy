using System;
using System.Globalization;
using System.Threading;
/*
 * Problem 5. Formatting Numbers
Write a program that reads 3 numbers:
integer a (0 <= a <= 500)
floating-point b
floating-point c
The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
The number a should be printed in hexadecimal, left aligned
Then the number a should be printed in binary form, padded with zeroes
The number b should be printed with 2 digits after the decimal point, right aligned
The number c should be printed with 3 digits after the decimal point, left aligned.
 */
class NumFormat
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int a;
        double b, c;
        Console.Write("a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());
        string aBin = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.WriteLine("{0,-1:X}|{1,00000000:2}|{2,1:0.00}|{3,-1:F3}|", a, aBin, b, c);
    }
}
