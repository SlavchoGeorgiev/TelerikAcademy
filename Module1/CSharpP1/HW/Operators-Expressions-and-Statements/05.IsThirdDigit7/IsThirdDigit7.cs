using System;
/*
 * Problem 5. Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is 7
 */
class IsThirdDigit7
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine((inputNum / 100) % 10 == 7);
    }
}
