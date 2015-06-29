using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            string exampleText = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";
            List<string> wordsArr = exampleText.Split(new char[] {' ','.',',','!'}, StringSplitOptions.RemoveEmptyEntries).ToList<string>();
            for (int i = 0; i < wordsArr.Count; i++)
            {
                for (int j = 0; j < wordsArr.Count; j++)
                {
                    if (wordsArr[i].ToLower() == wordsArr[j].ToLower() && i != j)
                    {
                        wordsArr[j] = String.Empty;
                    }
                }
            }

            wordsArr.Sort();
            foreach (var word in wordsArr)
            {
                if (word != String.Empty)
                {
                    Console.WriteLine("{0} - {1}", word.ToLower(), SubStrInText.SubStrInText.SubStrCounter(exampleText, word + " "));
                }
            }
        }
    }
}
