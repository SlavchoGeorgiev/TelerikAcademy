using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class P01
{
    public static string numSysChars = "abcdefghijklmnopqrstuvw";
    static void Main()
    {
        string inputString = Console.ReadLine();
        string[] separInput = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //foreach (var item in separInput)
        //{
        //    Console.WriteLine(item);
        //}
        long sum = 0;
        foreach (var num in separInput)
        {
            sum += CatSysToHuman(num);
        }
        Console.WriteLine("{1} = {0}", sum, HummanSysToCat(sum));
    }
    public static long CatSysToHuman(string input)
    {
        long result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int index = input.Length - i - 1;
            result += numSysChars.IndexOf(input[i]) * (long)Math.Pow(23, index);
        }
        return result;
    }
    public static string HummanSysToCat(long hummanNum)
    {
        StringBuilder result = new StringBuilder();
        while (hummanNum != 0)
        {
            int currDigit = (int)hummanNum % 23;
            hummanNum = hummanNum / 23;
            result.Insert(0, numSysChars[currDigit]);
        }
        return result.ToString();
    }
}