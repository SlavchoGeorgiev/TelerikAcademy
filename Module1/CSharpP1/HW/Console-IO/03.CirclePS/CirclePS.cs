using System;
using System.Globalization;
using System.Threading;
//Problem 3. Circle Perimeter and Area
//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
class CirclePS
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        double radius;
        Console.Write("Plase enter circle's radius:");
        radius = double.Parse(Console.ReadLine());
        Console.WriteLine("Cicle perimeter is {0:F2}", 2 * Math.PI * radius);
        Console.WriteLine("Cicle area is {0:F2}", Math.PI * radius * radius);
    }
}
