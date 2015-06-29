using System;
/*
 * Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
The bits are counted from right to left, starting from bit #0.
The result of the expression should be either 1 or 0.
 */
class ExtractBitNo3
{
    static void Main()
    {
        Console.Write("Enter integer number: ");
        uint inputNum = Convert.ToUInt32(Console.ReadLine());
        uint temp = 1;
        temp = temp << 3;
        temp = temp & inputNum;
        temp = temp >> 3;
        Console.WriteLine(temp);
    }
}