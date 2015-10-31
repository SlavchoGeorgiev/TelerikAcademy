namespace _04.LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            var list = ColectionGenerator.GenerateList(Console.In);

            var subsequence = FindLongestSubseqeunce(list);

            Console.Write("Longest subsequence is: ");
            subsequence.ForEach(x => Console.Write(x + " "));
        }

        public static List<int> FindLongestSubseqeunce(List<int> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException("Argument is null.");
            }

            var maxList = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                var currentList = new List<int>();
                var currentElement = list[i];
                currentList.Add(currentElement);
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (currentElement == list[j])
                    {
                        currentList.Add(currentElement);
                    }
                    else
                    {
                        i = j - 1;
                        break;
                    }
                }

                if (currentList.Count > maxList.Count)
                {
                    maxList = currentList;
                }
            }

            return maxList;
        }
    }
}
