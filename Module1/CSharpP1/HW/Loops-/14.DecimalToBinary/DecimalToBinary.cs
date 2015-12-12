using System;
//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
class DecimalToBinary
{
    static void Main()
    {
        long input;
        input = ReadDecimal();
        Console.WriteLine(DecToBin(input));
        Console.ReadLine();
    }

    private static long ReadDecimal()
    {
        string inputString = Console.ReadLine();
        try
        {
            return long.Parse(inputString);
        }
        catch (ArgumentOutOfRangeException aOORE)
        {
            Console.WriteLine("Error: {0}", aOORE.Message);
            return 0;
        }
        catch (OverflowException ofe)
        {
            Console.WriteLine("Error: {0}", ofe.Message);
            return 0;
        }
    }
    private static string DecToBin(long input)
    {
        byte currBit;
        string toBinary = string.Empty;
        while (input != 0)
        {
            currBit = (Byte)(input % 2);
            input = input / 2;
            char currBitLikeChar = Convert.ToChar(Convert.ToString(currBit));
            toBinary = String.Concat(currBitLikeChar, toBinary);
        }
        return toBinary;
    }
}