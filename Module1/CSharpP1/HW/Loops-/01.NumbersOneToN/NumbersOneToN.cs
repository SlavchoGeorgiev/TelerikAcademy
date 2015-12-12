using System;
//Problem 1. Numbers from 1 to N
//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
class NumbersOneToN
{
    static void Main()
    {
        int inputN = int.Parse(Console.ReadLine());
        for (int i = 1; i <= inputN; i++)
        {
            Console.Write("{0} ", i);
        }
    }
}
