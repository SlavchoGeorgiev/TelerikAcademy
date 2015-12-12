using System;
using System.Globalization;

public static class NumberAsWords
{
    static void Main()
    {
        int inputDigit;
        do
        {
            Console.Write("Enter number in the range [0...999]: ");
        } while (!(int.TryParse(Console.ReadLine(), out inputDigit)) || inputDigit < 0 || inputDigit > 999);
        Console.WriteLine(NumbersAsWordsBuilder(inputDigit));
    }
    static string NumbersAsWordsBuilder(int inputDig)
    {
        if (inputDig == 0)
        {
            return "Zero";
        }
        else if (CheckDigitNumbers(inputDig) == 1)
        {
            return DigitToText0to9(inputDig);
        }
        else if (CheckDigitNumbers(inputDig) == 2 && inputDig < 20)
        {
            return DigitToText10to19(inputDig);
        }
        else if (CheckDigitNumbers(inputDig) == 2)
        {
            return DigitToText20to90((inputDig / 10) * 10) + " " + DigitToText0to9(inputDig % 10).ToLower();
        }
        else if (inputDig % 100 == 0)
        {
            return DigitToText0to9(inputDig / 100) + " hundred";
        }
        else if (CheckDigitNumbers(inputDig % 100) == 1)
        {
            return DigitToText0to9(inputDig / 100) + " hundred and " + DigitToText0to9(inputDig % 100).ToLower();
        }
        else if (CheckDigitNumbers(inputDig % 100) == 2 && inputDig % 100 < 20)
        {
            return DigitToText0to9(inputDig / 100) + " hundred and " + DigitToText10to19(inputDig % 100).ToLower();
        }
        else if (CheckDigitNumbers(inputDig % 100) == 2)
        {
            return DigitToText0to9(inputDig / 100) + " hundred and " + DigitToText20to90(((inputDig % 100) / 10) * 10).ToLower() + " " + DigitToText0to9(inputDig % 10).ToLower();
        }
        return "Invalid input!";
    }
    public static string DigitToText0to9(int digit)
    {
        switch (digit)
        {
            case 0: return "";
            case 1: return "One";
            case 2: return "Two";
            case 3: return "Three";
            case 4: return "Four";
            case 5: return "Five";
            case 6: return "Six";
            case 7: return "Seven";
            case 8: return "Eight";
            case 9: return "Nine";
            default: return "Error";
        }
    }
    static string DigitToText10to19(int digit)
    {
        switch (digit)
        {
            case 10: return "Ten";
            case 11: return "Eleven";
            case 12: return "Twelve";
            case 13: return "Тhirteen";
            case 14: return "Fourteen";
            case 15: return "Fifteen";
            case 16: return "Sixteen";
            case 17: return "Seventeen";
            case 18: return "Еighteen";
            case 19: return "Nineteen";
            default: return "Error";
        }
    }
    static string DigitToText20to90(int digit)
    {
        switch (digit)
        {
            case 0: return "";
            case 20: return "Тwenty";
            case 30: return "Тhirty";
            case 40: return "Forty";
            case 50: return "Fifty";
            case 60: return "Sixty";
            case 70: return "Seventy";
            case 80: return "Eighty";
            case 90: return "Ninety";
            default: return "Error";
        }
    }
    static byte CheckDigitNumbers(int digit)
    {
        if (digit == 0)
        {
            return 1;
        }
        else
        {
            if (digit / 10.0 > 0 && digit / 10.0 < 1)
            {
                return 1;
            }
            else
            {
                if ((digit / 100.0 > 0) && (digit / 100.0 < 1))
                {
                    return 2;
                }
                else
                {
                    if ((digit / 1000.0 > 0) && (digit / 1000.0 < 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
