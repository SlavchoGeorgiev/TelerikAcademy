using System;
//Problem 10. Fibonacci Numbers
//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) 
//: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
class Program
{
    static void Main()
    {
        int previews = 0, current = 1, next = 0;
        int n = int.Parse(Console.ReadLine());
        Console.Write("{0}, ", previews);
        for (int i = 1; i < n; i++)
        {
            Console.Write("{0}, ", current);
            next = previews + current;
            previews = current;
            current = next;
        }

    }
}
