using System;
/*
Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0.
 */
class FourDigitNum
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        byte[] digit = new byte[4];
        digit[0] = (byte)(inputNum % 10);
        digit[1] = (byte)((inputNum / 10) % 10);
        digit[2] = (byte)((inputNum / 100) % 10);
        digit[3] = (byte)((inputNum / 1000) % 10);
        Console.WriteLine(digit[0] + digit[1] + digit[2] + digit[3]);
        Console.WriteLine(1000 * digit[0] + 100 * digit[1] + 10 * digit[2] + 1 * digit[3]);
        Console.WriteLine(1000 * digit[0] + 1 * digit[1] + 10 * digit[2] + 100 * digit[3]);
        Console.WriteLine(1 * digit[0] + 100 * digit[1] + 10 * digit[2] + 1000 * digit[3]);
    }
}