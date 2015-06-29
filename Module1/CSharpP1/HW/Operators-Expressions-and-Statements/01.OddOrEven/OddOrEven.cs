using System;
/*
 * Problem 1. Odd or Even Integers
*Write an expression that checks if given integer is odd or even.
 */
class OddOrEven
{
    static void Main()
    {
        int inputNumber;
        inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(!(inputNumber % 2 == 0)); // Is odd
        //if (inputNumber % 2 == 0)
        //{
        //    Console.WriteLine(false);
        //}
        //else
        //{
        //    Console.WriteLine(true);
        //}
    }
}
