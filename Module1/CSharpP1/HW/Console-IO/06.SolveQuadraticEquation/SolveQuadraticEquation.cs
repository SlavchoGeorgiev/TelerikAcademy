using System;

class SolveQuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("ax^2+bx+c=0");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double d = b * b - 4 * a * c;
        if (d == 0)
        {
            Console.WriteLine("There is exactly one real root");
            Console.WriteLine("X = {0}", -(b / (2 * a)));
        }
        else
        {
            if (d < 0)
            {
                Console.WriteLine("There are no real roots.");
            }
            else
            {
                Console.WriteLine("X1 = {0}", (-b + Math.Sqrt(d)) / (2 * a));
                Console.WriteLine("X2 = {0}", (-b - Math.Sqrt(d)) / (2 * a));
            }
        }
    }
}
