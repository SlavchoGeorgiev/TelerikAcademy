using System;
/*
Problem 7. Point in a Circle
Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */
class IsPointInCircle
{
    static void Main()
    {
        //(x-h)^2+(y-k)^2=r^2
        double x, y, h, k, r;
        h = 0;
        k = 0;
        r = 2;
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        Console.WriteLine((x - h) * (x - h) + (y - k) * (y - k) <= r * r);
        //if (Math.Pow((x - h), 2) + Math.Pow((y - k), 2) <= Math.Pow(r, 2))
        //{
        //    Console.WriteLine("Point({0},{1}) is within the circle K( ({2},{3}), {4}).", x, y, h, k, r);
        //}
        //else
        //{
        //    Console.WriteLine("Point({0},{1}) is out of the circle K( ({2},{3}), {4}).", x, y, h, k, r);
        //}
    }
}