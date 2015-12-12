using System;
using System.Collections.Generic;
//Problem 12.* Zero Subset
//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
class ZeroSubset
{
    static void Main()
    {
        Console.Write("Enter five integer numbers separed by space : ");
        string input = Console.ReadLine();
        char[] separators = {' '};
        string[] numberAsString = input.Split(separators ,StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[numberAsString.Length];
        for (int i = 0; i < numbers.Length; i++)
		{
            numbers[i] = int.Parse(numberAsString[i]);
		}
        PrintCombinations(numbers);
    }

    static List<int> IsSumOfNextElementAndInputValueEqualToSum(int[] numbers, int sum, int startIndex = 0, int InputSum = 0)
    {
        List<int> index = new List<int>();
        for (int i = startIndex ;i < numbers.Length; i++)
        {
            if (sum + numbers[i] == InputSum)
            {
                index.Add(i);
            }
        }
        return index;
    }
    static void PrintCombinations(int[] numbers, int inputSum = 0)
    {
        for (int combinationLenght = 2; combinationLenght <= numbers.Length; combinationLenght++)
        {
            for (int currStartPosition = 0; currStartPosition < numbers.Length - 1; currStartPosition++)
            {
                int sumOfBeforeElemenst = 0;
                int currEndPosition = currStartPosition + combinationLenght - 1;
                for (int i = currStartPosition; i < currEndPosition && currEndPosition  < numbers.Length; i++)
                {
                    sumOfBeforeElemenst = sumOfBeforeElemenst + numbers[i];
                }
                for (int i = currEndPosition; i < numbers.Length; i++)
                {
                    List<int> currIndexesOfSum = IsSumOfNextElementAndInputValueEqualToSum(numbers, sumOfBeforeElemenst, i);
                    if (currIndexesOfSum.Count > 0)
                    {
                        foreach (var index in currIndexesOfSum)
                        {
                            for (int indexOfBeforeElements = currStartPosition; indexOfBeforeElements < currEndPosition; indexOfBeforeElements++)
                            {
                                Console.Write("{0} + ", numbers[indexOfBeforeElements]);
                            }
                            Console.Write("{0} = ", numbers[index]);
                            Console.WriteLine(inputSum);
                        }
                    }
                }
            }            
        }
    }
}
