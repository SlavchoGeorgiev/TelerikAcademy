using System;
//Problem 9. Sum of n Numbers
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum.
class SumOfNNums
{
    static void Main()
    {
        int elementsNumber = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 0; i < elementsNumber; i++)
        {
            sum = sum + double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Sum is {0}.", sum);
    }
}
