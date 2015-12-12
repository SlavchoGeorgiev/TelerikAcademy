using System;
//Problem 3. Check for a Play Card
//Classical play cards use the following signs to designate the card face:
//`2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise.
class CheckPlayCard
{
    static void Main()
    {
        string[] validSingChar = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        string input = Console.ReadLine();
        bool isValid = false;
        foreach (string ch in validSingChar)
        {
            if (ch == input)
            {
                isValid = true;
            }
        }
        if (isValid)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}