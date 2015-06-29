using System;
/*
 * Problem 14. Modify a Bit at Given Position
We are given an integer number n, a bit value v (v=0 or 1) and a position p.
Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
class ModifyBitAtPosition
{
    static void Main()
    {
        Console.Write("n = ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("p = ");
        byte position = byte.Parse(Console.ReadLine());
        Console.Write("(v=0 or 1) v = ");
        byte value = byte.Parse(Console.ReadLine());
        int mask, result;
        if (value == 0)
        {
            mask = ~(1 << position);
            result = number & mask;
        }
        else
        {
            mask = 1 << position;
            result = number | mask;
        }
        Console.WriteLine(result);
    }
}