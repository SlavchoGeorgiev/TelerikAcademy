using System;
/*
 * Problem 9. Trapezoids
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
class TrapezoidArea
{
    static void Main()
    {
        double sideA, sideB, height, area;
        Console.Write("Side a = ");
        sideA = double.Parse(Console.ReadLine());
        Console.Write("Side b = ");
        sideB = double.Parse(Console.ReadLine());
        Console.Write("height = ");
        height = double.Parse(Console.ReadLine());
        area = (sideA + sideB) / 2 * height;
        Console.WriteLine("Area = {0}", area);
    }
}
