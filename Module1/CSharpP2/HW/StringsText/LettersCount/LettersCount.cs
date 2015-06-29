using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            string exampleText = "Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.";
            char[] letterArr = exampleText.ToCharArray();
            for (int i = 0; i < letterArr.Length; i++)
            {
                for (int j = 0; j < letterArr.Length; j++)
                {
                    if (letterArr[i].ToString().ToLower() == letterArr[j].ToString().ToLower() && i != j)
                    {
                        letterArr[j] = 'Ð';
                    }
                }
            }
            foreach (var letter in letterArr)
            {
                if (letter != 'Ð')
                {
                    Console.WriteLine("{0} - {1}", letter.ToString().ToLower(), SubStrInText.SubStrInText.SubStrCounter(exampleText, letter.ToString()));
                }
            }
        }
    }
}
