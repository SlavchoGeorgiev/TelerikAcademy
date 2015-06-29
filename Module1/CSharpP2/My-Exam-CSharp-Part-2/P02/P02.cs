using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
class P02
{
    static void Main()
    {
        var foundNumbers = new List<BigInteger>();
        string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int pointer = 1;
        while (pointer < input.Length)
        {
            var currNum = long.Parse(input[pointer]);
            var befNum = long.Parse(input[pointer - 1]);
            var absDif = Math.Abs(currNum - befNum);
            if (absDif % 2 == 0)
            {
                foundNumbers.Add(absDif);
            }
            if (absDif % 2 == 0)
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
