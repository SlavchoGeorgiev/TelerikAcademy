using System;
using System.Text;
//Problem 16. Decimal to Hexadecimal Number
//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
class DecimalToHexadecimal
{
    static void Main()
    {
        long input = Convert.ToInt64(Console.ReadLine());
        string result = DecToHex(input);
        Console.WriteLine(result);
    }

    private static string DecToHex(long input)
    {
        StringBuilder resultSB = new StringBuilder();
        while (input != 0)
        {
            long currentRimainders = input % 16;
            input = input / 16;
            resultSB.Append(OneDigitDecToHex(currentRimainders));
        }
        string result = ReverseString(resultSB.ToString());
        return result;
    }
    private static string OneDigitDecToHex(long input)
    {
        switch (input)
        {
            case 0:
                return "0";
            case 1:
                return "1";
            case 2:
                return "2";
            case 3:
                return "3";
            case 4:
                return "4";
            case 5:
                return "5";
            case 6:
                return "6";
            case 7:
                return "7";
            case 8:
                return "8";
            case 9:
                return "9";
            case 10:
                return "A";
            case 11:
                return "B";
            case 12:
                return "C";
            case 13:
                return "D";
            case 14:
                return "E";
            case 15:
                return "F";
            default:
                return string.Empty;
        }
    }
    private static string ReverseString(string inputStr)
    {
        StringBuilder result = new StringBuilder();
        for (int i = inputStr.Length - 1; i >= 0; i--)
        {
            result.Append(inputStr[i]);
        }
        return result.ToString();
    }
}