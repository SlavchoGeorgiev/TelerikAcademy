using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class P04
{
    static int currLine = 0;
    static string[] code;
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        code = new string[n];
        for (int i = 0; i < n; i++)
        {
            code[i] = Console.ReadLine();
        }
        while (MethodStartLine(currLine) != -1)
        {
            currLine = MethodStartLine(currLine);
            string metodName = MetodName(currLine);
            Console.Write(metodName);
            Console.Write(" -> ");
            int firstBracket = FirstOpenBracketLine(currLine);
            currLine = firstBracket;
            int metodEnd = FindEnd(currLine + 1);
            currLine = metodEnd;
            //Console.WriteLine(currLine);
            List<string> methodsUsed = CountMethods(firstBracket, metodEnd);
            StringBuilder methods = new StringBuilder();
            for (int i = 0; i < methodsUsed.Count - 1; i++)
            {
                methods.Append(methodsUsed[i]);
                methods.Append(", ");
            }
            methods.Append(methodsUsed[methodsUsed.Count - 1]);
            Console.Write(methodsUsed.Count);
            Console.Write(" -> ");
            Console.Write(methods.ToString());
            Console.WriteLine();
        }
    }

    private static List<string> CountMethods(int firstBracket, int metodEnd)
    {
        List<string> methods = new List<string>();
        for (int i = firstBracket; i <= metodEnd; i++)
        {
            int index = 0;
            while (code[i].IndexOf('.', index) >= 0)
            {
                index = code[i].IndexOf('.', index);
                index++;
                int endMethodIndex = code[i].IndexOf('(', index);
                if (index >= 0 && index < code[i].Length && endMethodIndex - index >=0)
                {
                    methods.Add(code[i].Substring(index, endMethodIndex - index));
                }
            }
        }
        return methods;
    }

    private static int FindEnd(int currLine)
    {
        int bracketCounter = 1;
        while (bracketCounter > 0)
        {
            if (code[currLine].Contains("{"))
            {
                bracketCounter++;
            }
            if (code[currLine].Contains("}"))
            {
                bracketCounter--;
            }
            currLine++;
        }
        return currLine;
    }

    private static string MetodName(int currLine)
    {
        string name = code[currLine];
        name = name.TrimStart(' ');
        string[] comands = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        name = comands[2];
        name = name.Substring(0, name.IndexOf('('));
        return name;
    }
    public static int MethodStartLine(int beginFrom)
    {
        for (int i = beginFrom; i < code.Length; i++)
        {
            if (code[i].Contains("static"))
            {
                return i;
            }
        }
        return -1;
    }
    public static int FirstOpenBracketLine(int beginFrom)
    {
        for (int i = beginFrom; i < code.Length; i++)
        {
            if (code[i].Contains("{"))
            {
                return i;
            }
        }
        return -1;
    }
}
