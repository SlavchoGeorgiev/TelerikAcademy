using System;
//Problem 10. Odd and Even Product
//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
class OddAndEvenProduct
{
    static void Main()
    {
        string input = Console.ReadLine();
        int oddProduct = 1;
        int evenProduct = 1;
        string[] sepInput = input.Split(' ');
        int currNumber;
        for (int i = 0; i < sepInput.Length; i++)
        {
            currNumber = int.Parse(sepInput[i]);
            if ((i + 1) % 2 == 0)
            {
                evenProduct = evenProduct * currNumber;
            }
            else
            {
                oddProduct = oddProduct * currNumber;
            }
        }
        string result = "no";
        if (evenProduct == oddProduct)
        {
            result = "yes";
        }
        Console.WriteLine("odd_product = {0}", oddProduct);
        Console.WriteLine("even_product = {0}", evenProduct);
        Console.WriteLine("result = {0}", result);
    }
}