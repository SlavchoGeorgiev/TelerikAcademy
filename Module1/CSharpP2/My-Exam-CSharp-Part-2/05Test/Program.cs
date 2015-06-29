using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Test
{
    class Program
    {
        static void Main(string[] args)
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
                    if (!IsItTrue(comand,firstDigit,secondDigit,result))
                    {
                        if (comand == "before")
                        {
                            result.Remove(firstDigit);
                            result.Insert(result.IndexOf(secondDigit), firstDigit);
                        }
                        else
                        {
                            result.Remove(firstDigit);
                            result.Insert(result.IndexOf(secondDigit) + 1, firstDigit);
                        }
                    }
                }
                else if (result.Contains(firstDigit) && !result.Contains(secondDigit))
                {
                    if (comand == "before")
                    {
                        result.Insert(result.IndexOf(firstDigit) + 1, secondDigit);
                    }
                    else
                    {
                        result.Insert(result.IndexOf(firstDigit), secondDigit);
                    }
                }
                else if (!result.Contains(firstDigit) && result.Contains(secondDigit))
                {
                    if (comand == "before")
                    {
                        result.Insert(result.IndexOf(secondDigit), firstDigit);
                    }
                    else
                    {
                        result.Insert(result.IndexOf(secondDigit) + 1, firstDigit);
                    }
                }
                else if (result.Contains(firstDigit) && result.Contains(secondDigit))
                {
                    if (comand == "before")
                    {
                        result.Remove(firstDigit);
                        result.Insert(result.IndexOf(secondDigit), firstDigit);
                    }
                    else
                    {
                        result.Remove(firstDigit);
                        result.Insert(result.IndexOf(secondDigit) + 1, firstDigit);
                    }
                }
            }
            Print(result);
        }
        public static void Print(List<char> toPrint)
        {
            for (int i = 0; i < toPrint.Count; i++)
            {
                Console.Write(toPrint[i]);
            }
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
        private static string FindComand(string line)
        {
            if (line.Contains("before"))
            {
                return "before";
            }
            else
            {
                return "after";
            }
        }
    }
}
