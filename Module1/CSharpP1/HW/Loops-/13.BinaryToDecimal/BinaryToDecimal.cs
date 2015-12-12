using System;
//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
class BinaryToDecimal
{
    static void Main()
    {
        string inputBinaryNumber = Console.ReadLine();
        try
        {
            Console.WriteLine(BinToDec(inputBinaryNumber));
        }
        catch (FormatException fe)
        {
            Console.WriteLine("Error: {0}", fe.Message);
        }
        Console.ReadLine();
    }

    static long BinToDec(string input)
    {
        long result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '0' || input[i] == '1')
            {
                result += Int32.Parse(Convert.ToString(input[i])) * (int)Math.Pow(2, input.Length - 1 - i);
            }
            else
            {
                throw new FormatException("Invalid input only zero an one are allowed");
            }
        }
        return result;
    }
}