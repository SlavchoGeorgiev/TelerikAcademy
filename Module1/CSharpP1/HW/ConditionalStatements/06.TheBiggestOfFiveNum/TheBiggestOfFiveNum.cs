using System;
//Problem 6. The Biggest of Five Numbers
//Write a program that finds the biggest of five numbers by using only five if statements.
class TheBiggestOfFiveNum
{
    static void Main()
    {
        double num1, num2, num3, num4, num5;
        do
        {
            Console.Write("a = ");
        } while (!(double.TryParse(Console.ReadLine(), out num1)));
        do
        {
            Console.Write("b = ");
        } while (!(double.TryParse(Console.ReadLine(), out num2)));
        do
        {
            Console.Write("c = ");
        } while (!(double.TryParse(Console.ReadLine(), out num3)));
        do
        {
            Console.Write("d = ");
        } while (!(double.TryParse(Console.ReadLine(), out num4)));
        do
        {
            Console.Write("e = ");
        } while (!(double.TryParse(Console.ReadLine(), out num5)));
        Console.Write("bigest = ");
        if (num1 >= num2 && num1 >= num3 && num1 >= num4 && num1 >= num5)
        {
            Console.WriteLine(num1);
        }
        else if (num2 >= num1 && num2 >= num3 && num2 >= num4 && num2 >= num5)
        {
            Console.WriteLine(num2);
        }
        else if (num3 >= num2 && num3 >= num1 && num3 >= num4 && num3 >= num5)
        {
            Console.WriteLine(num3);
        }
        else if (num4 >= num2 && num4 >= num3 && num4 >= num1 && num4 >= num5)
        {
            Console.WriteLine(num4);
        }
        else
        {
            Console.WriteLine(num5);
        }
    }
}