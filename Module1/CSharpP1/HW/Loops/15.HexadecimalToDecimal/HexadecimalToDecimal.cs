using System;
//Problem 15. Hexadecimal to Decimal Number
//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

class HexadecimalToDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        long resultToDecimal = HexToDec(input);
        Console.WriteLine(resultToDecimal);
    }

    static long HexToDec(string input)
    {
        long result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            result += OneHexDigitToDecimal(input[i]) * (long)Math.Pow(16, input.Length - 1 - i);
        }
        return result;
    }

    static long OneHexDigitToDecimal(char hexDigit)
    {
        switch (char.ToUpper(hexDigit))
        {
            case '0':
                return 0;
            case '1':
                return 1;
            case '2':
                return 2;
            case '3':
                return 3;
            case '4':
                return 4;
            case '5':
                return 5;
            case '6':
                return 6;
            case '7':
                return 7;
            case '8':
                return 8;
            case '9':
                return 9;
            case 'A':
                return 10;
            case 'B':
                return 11;
            case 'C':
                return 12;
            case 'D':
                return 13;
            case 'E':
                return 14;
            case 'F':
                return 15;
        }
        return 0;
    }
}