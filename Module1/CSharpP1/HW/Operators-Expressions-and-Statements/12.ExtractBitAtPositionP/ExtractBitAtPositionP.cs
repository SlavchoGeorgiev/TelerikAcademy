using System;
/*
 * Problem 12. Extract Bit from Integer
 * Write an expression that extracts from given integer n the value of given bit at index p
 */
class ExtractBitAtPositionP
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
        Console.WriteLine("bit @ {0} is {1}", p, temp);
    }
}
