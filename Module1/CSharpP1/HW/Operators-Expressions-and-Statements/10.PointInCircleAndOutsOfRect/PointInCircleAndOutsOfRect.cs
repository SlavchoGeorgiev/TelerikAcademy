using System;
/*
 * Problem 10. Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2)
 */
class PointInCircleAndOutsOfRect
{
    static void Main()
    {
        //(x-h)^2+(y-k)^2=r^2
        double x, y, h, k, r, top, left, width, height;
        h = 1;
        k = 1;
        r = 1.5;
        top = 1;
        left = -1;
        width = 6;
        height = 2;
        Console.WriteLine("Enter point(x,y)");
        Console.Write("x = ");
        x = double.Parse(Console.ReadLine());
        Console.Write("y = ");
        y = double.Parse(Console.ReadLine());
        if (((x - h) * (x - h) + (y - k) * (y - k) <= r * r) && (x < left || x > (left + width) || y > top || y < (top - height)))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
        // (Math.Pow((x-h),2) + Math.Pow((y-k),2) <= Math.Pow(r,2)) && (x < left || x > (left + width) || y > top || y < (top - height)) 
        // if this expression is "true" =>
        // =>  point (x, y) is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

        //if (Math.Pow((x - h), 2) + Math.Pow((y - k), 2) <= Math.Pow(r, 2))
        //{
        //    Console.WriteLine("Point({0},{1}) is within the circle K( ({2},{3}), {4}).", x, y, h, k, r);
        //}
        //else
        //{
        //    Console.WriteLine("Point({0},{1}) is out of the circle K( ({2},{3}), {4}).", x, y, h, k, r);
        //}
        //if (x < left || x > (left + width) || y > top || y < (top - height))
        //{
        //    Console.WriteLine("Point({0},{1}) is out of the rectangle R(top={2}, left={3}, width={4}, height={5}).", x, y, top, left, width, height);
        //}
        //else
        //{
        //    Console.WriteLine("Point({0},{1}) is within the rectangle R(top={2}, left={3}, width={4}, height={5}).", x, y, top, left, width, height);
        //}
    }
}
