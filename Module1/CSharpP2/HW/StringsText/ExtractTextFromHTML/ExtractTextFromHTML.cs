using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractTextFromHTML
{
    class ExtractTextFromHTML
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = string.Empty;
            List<string> inputLines = new List<string>();

            do
            {
                input = Console.ReadLine().Trim();
                inputLines.Add(input);
            } while (input != string.Empty);

            input = string.Join(" ", inputLines);
            StringBuilder title = new StringBuilder();
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (i < input.Length - 7 && input.Substring(i, 7) == "<title>")
                {
                    i += 7;
                    while (input[i] != '<')
                    {
                        title.Append(input[i]);
                        i++;
                    }
                }
                if (input[i] == '<')
                {
                    while (input[i] != '>')
                    {
                        i++;
                    }
                }
                if (i < input.Length && input[i] != '>')
                {
                    text.Append(input[i]);
                }
            }

            Console.WriteLine("Title: {0}\n\nText: {1}", title, text.ToString().Trim());
        }
    }
}
