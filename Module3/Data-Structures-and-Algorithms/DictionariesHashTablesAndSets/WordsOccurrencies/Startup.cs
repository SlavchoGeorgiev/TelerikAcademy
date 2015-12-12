namespace WordsOccurrencies
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string text = File.ReadAllText("words.txt");
            WordsCounter(text);
        }

        public static void WordsCounter(string text)
        {
            string[] words = text.Split(" .,!<>:;\"!@#$%^&*()_+=-–?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCounts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                var lowerCaseWord = word.ToLower();

                if (!wordsCounts.Keys.Contains(lowerCaseWord))
                {
                    wordsCounts[lowerCaseWord] = 1;
                }
                else
                {
                    wordsCounts[lowerCaseWord]++;
                }
            }

            var orderedWords = wordsCounts
                .OrderByDescending(p => p.Value)
                .Select(p => new { Key = p.Key, Value = p.Value})
                .ToList();

            foreach (var pair in orderedWords)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
