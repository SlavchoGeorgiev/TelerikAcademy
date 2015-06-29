using System;
/*
 * Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
 */
class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        int v = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter bit number (counting from 0): ");
        byte p = Convert.ToByte(Console.ReadLine());
        int temp = 1;
        temp = temp << p;
        temp = temp & v;
        temp = temp >> p;
        Console.WriteLine(temp == 1);
    }
}