using System;

public class BitExchaneAtPQK
{
    static void Main()
    {
        Console.Write("Enter 32-bit unsigned integer: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.Write("p = ");
        byte p = byte.Parse(Console.ReadLine()); //start bit p
        Console.Write("q = ");
        byte q = byte.Parse(Console.ReadLine()); //start bit q
        Console.Write("k = ");
        byte k = byte.Parse(Console.ReadLine()); //range k
        Console.WriteLine(BitExchanger(number, p, q, k));
    }
    public static uint BitExchanger(uint number, byte p, byte q, byte k)
    {
        if (p > q)
        {
            byte tem;
            tem = p;
            p = q;
            q = tem;
        }
        if (p < 0 || p + k - 1 > 32 || q <= 0 || q + k - 1 > 32)
        {
            throw new ArgumentOutOfRangeException("out of range");
        }
        if (p + k - 1 >= q)
        {
            throw new ArgumentOutOfRangeException("overlapping");
        }
        uint mask = 0, temp, tempForCopy;
        for (int i = 0; i < (k - 1); i++)   //Generate mask range
        {                                   //Generate mask range
            ++mask;                         //Generate mask range
            mask = mask << 1;               //Generate mask range
        }                                   //Generate mask range
        ++mask;                             //Generate mask range
        // if number = 355231381
        mask = mask << (byte)p;                                     // 0000 0000 0000 0000 0000 0000 0011 1000
        temp = number;                                              // 0001 0101 0010 1100 0110 0110 1001 0101
        temp = temp | mask;                                         // 0001 0101 0010 1100 0110 0110 1011 1101
        mask = mask << (byte)(q - p);                               // 0000 0111 0000 0000 0000 0000 0000 0000
        temp = temp | mask;                                         // 0001 0111 0010 1100 0110 0110 1011 1101
        tempForCopy = number & mask;                                // 0000 0101 0000 0000 0000 0000 0000 0000
        tempForCopy = tempForCopy >> (byte)(q - p);                 // 0000 0000 0000 0000 0000 0000 0010 1000
        tempForCopy = tempForCopy | ~(mask >> (byte)(q - p));       // 1111 1111 1111 1111 1111 1111 1110 1111
        temp = temp & tempForCopy;                                  // 0001 0111 0010 1100 0110 0110 1010 1101
        mask = mask >> (byte)(q - p);                               // 0000 0000 0000 0000 0000 0000 0011 1000
        tempForCopy = number & mask;                                // 0000 0000 0000 0000 0000 0000 0001 0000
        tempForCopy = tempForCopy << (byte)(q - p);                 // 0000 0010 0000 0000 0000 0000 0000 0000
        tempForCopy = tempForCopy | ~(mask << (byte)(q - p));       // 1111 1010 1111 1111 1111 1111 1111 1111
        temp = temp & tempForCopy;                                  // 0001 0010 0010 1100 0110 0110 1010 1101
        number = temp;
        return number;
    }
}

