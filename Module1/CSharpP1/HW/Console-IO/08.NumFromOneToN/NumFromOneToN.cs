using System;
//Problem 8. Numbers from 1 to n
//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
class NumFromOneToN
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        for (int i = 1; i <= input; i++)
        {
            Console.WriteLine(i);
        }
    }
}
