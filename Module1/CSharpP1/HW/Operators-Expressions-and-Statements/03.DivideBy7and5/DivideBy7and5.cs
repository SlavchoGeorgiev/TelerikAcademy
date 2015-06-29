using System;
//Problem 3. Divide by 7 and 5
//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time
class DivideBy7and5
{
    static void Main()
    {
        int inputNum;
        inputNum = int.Parse(Console.ReadLine());
        Console.WriteLine(inputNum % 7 == 0 && inputNum % 5 == 0 && inputNum != 0);
    }
}
