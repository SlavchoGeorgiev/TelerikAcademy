using System;
//Problem 7. Sort 3 Numbers with Nested Ifs
//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
class DescendingOrder
{
    static void Main()
    {
        double num1, num2, num3;
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
        if (num1 >= num2 && num1 >= num3)
        {
            if (num2 >= num3)
            {
                Console.WriteLine("{0}, {1}, {2}", num1, num2, num3);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", num1, num3, num2);
            }
        }
        else
        {
            if (num2 >= num3)
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("{0}, {1}, {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", num2, num3, num1);
                }
            }
            else
            {
                if (num1 >= num2)
                {
                    Console.WriteLine("{0}, {1}, {2}", num3, num1, num2);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", num3, num2, num1);
                }
            }
        }

    }
}