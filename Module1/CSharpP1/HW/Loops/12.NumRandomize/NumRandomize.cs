using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
class NumRandomize
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];
        for (int i = 0; i < nums.Length; i++)
		{
            nums[i] = i + 1;
		}
        Random rnd = new Random();
        int[] randomized = nums.OrderBy(x => rnd.Next()).ToArray();
        foreach (var item in randomized)
        {
            Console.Write("{0} ", item);
        }
    }
}