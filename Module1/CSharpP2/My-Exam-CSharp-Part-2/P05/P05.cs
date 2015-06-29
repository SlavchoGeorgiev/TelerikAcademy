using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class P05
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] line = new string[n];
        List<char> result = new List<char>();
        for (int i = 0; i < n; i++)
        {
            line[i] = Console.ReadLine();
            char firstDigit = line[i][0];
            char secondDigit = line[i].ToString()[line[i].ToString().Length - 1];
            string comand = FindComand(line[i]);
            //Console.WriteLine(secondDigit);
            if (!result.Contains(firstDigit) && !result.Contains(secondDigit))
            {
                result.Insert(0, firstDigit);
                result.Insert(0, secondDigit);
                if (!IsItTrue(comand, firstDigit, secondDigit, result))
                {
                    if (comand == "before")
                    {
                        result.Remove(firstDigit);
                        result.Insert(result.IndexOf(secondDigit), firstDigit);
                    }
                    else if (comand == "after")
                    {
                        result.Remove(secondDigit);
                        result.Insert(result.IndexOf(firstDigit), secondDigit);
                    }
                    Corect(result, firstDigit, secondDigit, comand);
                }
            }
            else if (result.Contains(firstDigit) && !result.Contains(secondDigit))
            {
                result.Insert(0, secondDigit);
                if (!IsItTrue(comand, firstDigit, secondDigit, result))
                {
                    Corect(result, firstDigit, secondDigit, comand);
                }
            }
            else if (!result.Contains(firstDigit) && result.Contains(secondDigit))
            {
                result.Insert(0, firstDigit);
                if (!IsItTrue(comand, firstDigit, secondDigit, result))
                {
                    Corect(result, firstDigit, secondDigit, comand);
                }
            }
            else if (result.Contains(firstDigit) && result.Contains(secondDigit))
            {
                if (!IsItTrue(comand, firstDigit, secondDigit, result))
                {
                    //Corect(result, firstDigit, secondDigit);
                }
            }
        }
        StringBuilder finalResult = new StringBuilder();
        for (int i = result.Count - 1; i >= 0; i--)
        {
            finalResult.Append(result[i]);
        }
        Console.WriteLine(finalResult.ToString());
    }

    private static bool IsItTrue(string comand, char firstDigit, char secondDigit, List<char> result)
    {
        if (comand == "before" && result.IndexOf(firstDigit) < result.IndexOf(secondDigit))
        {
            return true;
        }
        else if (comand == "before" && result.IndexOf(firstDigit) > result.IndexOf(secondDigit))
        {
            return false;
        }
        else if (comand == "after" && result.IndexOf(firstDigit) > result.IndexOf(secondDigit))
        {
            return true;
        }
        else if (comand == "after" && result.IndexOf(firstDigit) < result.IndexOf(secondDigit))
        {
            return false;
        }
        return false;
    }
    public static string FindComand(string input)
    {
        return input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[2];
    }
    public static void Corect(List<char> result, char firstDigit, char secondDigit, string comand)
    {
        if (comand == "before")
        {
            result.Remove(firstDigit);
            result.Insert(result.IndexOf(secondDigit), firstDigit);
        }
        else if (comand == "after")
        {
            result.Remove(firstDigit);
            result.Insert(result.IndexOf(secondDigit) + 1, firstDigit);
        }
    }
}
