using System;
using System.Collections.Generic;
using System.Numerics;

public class EvenDifferences
{
    public static void Main()
    {
        var foundNumbers = new List<BigInteger>();
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int pointer = 1;

        while (pointer < input.Length)
        {
            var currentNumber = long.Parse(input[pointer]);
            var beforeNumber = long.Parse(input[pointer - 1]);
            var absDifference = Math.Abs(currentNumber - beforeNumber);

            if (absDifference % 2 == 0)
            {
                foundNumbers.Add(absDifference);
            }

            if (absDifference % 2 == 0)
            {
                pointer += 2;
            }
            else
            {
                pointer++;
            }
        }

        BigInteger sum = 0;

        foreach (var num in foundNumbers)
        {
            sum += num;
        }

        Console.WriteLine(sum);
    }
}
