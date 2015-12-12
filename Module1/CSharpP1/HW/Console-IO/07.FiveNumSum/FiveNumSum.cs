using System;
using System.Globalization;
using System.Threading;
//Problem 7. Sum of 5 Numbers
//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
class FiveNumSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        string input = Console.ReadLine();
        string[] numAsString = input.Split(' ');
        double sum = 0;
        foreach (string element in numAsString)
        {
            double currentNum = 0;
            if (!string.IsNullOrEmpty(element))
            {
                double.TryParse(element,out currentNum);
                sum = sum + currentNum;
                if (currentNum != 0)
                {
                    Console.Write("{0} + ", currentNum);
                }
            }
        }
        Console.CursorLeft = Console.CursorLeft - 3;
        Console.WriteLine(" = {0}", sum);
    }
}