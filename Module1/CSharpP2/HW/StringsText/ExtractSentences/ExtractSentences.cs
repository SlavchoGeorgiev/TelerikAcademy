using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            string inputText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            Console.WriteLine("Initial text: {0}", inputText);
            Console.WriteLine();
            Console.WriteLine(ExtractConteiningSenteces(inputText, "in"));
        }
        public static string ExtractConteiningSenteces(string text, string word)
        {
            word = " " + word + " ";
            StringBuilder sb = new StringBuilder();
            string[] sepatedInSentences = text.Split(new Char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var sentences in sepatedInSentences)
	        {

                if (sentences.Contains(word))
                {
                    sb.Append(sentences);
                    sb.Append(".");
                }
	        }
            return sb.ToString();
        }
    }
}
