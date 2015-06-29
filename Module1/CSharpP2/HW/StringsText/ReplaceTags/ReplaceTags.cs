using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceTags
{
    class ReplaceTags
    {
        static void Main()
        {
        
            string input = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            StringBuilder sb = new StringBuilder();
            bool inATag = false;
            for (int i = 0; i < input.Length; i++)
            {
                sb.Append(input[i]);
                if (i > 0 && input[i] == 'a' && input[i - 1] == '<')
                {
                    inATag = true;
                }
                if (inATag && input[i] == '>')
                {
                    sb[sb.Length - 1] = ']';
                    sb.Remove(sb.Length - 2, 1);
                    inATag = false;
                }
            }
            sb.Replace("<a href=\"", "[URL=").Replace("</a>", "[/URL]");
            Console.WriteLine(sb);
        }
    }
}
