using System;
//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
class NumInIntervalDivByN
{
    static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int p = 0;
        int diveder = 5;
        for (int currNum = start; currNum <= end; currNum++)
        {
            if (currNum % diveder == 0)
            {
                p++;
            }
        }
        Console.WriteLine("p = {0}", p);
    }
}
