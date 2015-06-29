using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            Console.WriteLine(sentence);
            string[] byWords = sentence.Remove(sentence.Length - 1).Split(' ');
            StringBuilder newSentence = new StringBuilder();
            bool[] commaWordIndex = new bool[byWords.Length];
            for (int i = 0; i < byWords.Length; i++)
            {
                if (byWords[i].Contains(','))
                {
                    commaWordIndex[byWords.Length - i -1] = true;
                }
                
            }
            for (int i = byWords.Length - 1; i >= 0; i--)
            {
                string currentWord = byWords[i].Replace(",", "");
                newSentence.Append(currentWord);
                if (commaWordIndex[i])
                {
                    newSentence.Append(",");
                }
                newSentence.Append(' ');
            }
            newSentence.Remove(newSentence.Length - 1,1);
            newSentence.Append(sentence[sentence.Length - 1]);
            Console.WriteLine(newSentence.ToString());
        }
    }
}
