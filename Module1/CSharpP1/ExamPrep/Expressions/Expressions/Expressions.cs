using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expressions
{
    class Expressions
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0:F2}", CalaculatePlusMinus(input, 0));
        }
        static double CalaculatePlusMinus(string input, int startPosition)
        {
            int currPosition = startPosition;
            double sum = 0;
            double nextNum = 0;
            double currNUm = double.Parse(input[currPosition].ToString());
            char currOperator = ' ';
            char nextOperator = ' ';
            sum = sum + currNUm;
            while (currPosition <= input.Length - 3)
            {
                currOperator = input[currPosition + 1];
                nextNum = double.Parse(input[currPosition + 2].ToString());
                if (currPosition + 3 < input.Length)
                {
                    nextOperator = input[currPosition + 3];
                }
                else
                {
                    nextOperator = ' ';
                }
                if (currOperator == '*' || currOperator == '/')
                {
                    sum = sum + CalculateMultDev(input, currPosition);
                    currPosition = currPosition + 2;
                }
                else if (currOperator == '+' && nextOperator != '*' && nextOperator != '/' && nextOperator != '(' && nextOperator != ')')
                {
                    sum = sum + nextNum;
                    currPosition = currPosition + 2;
                }
                else if (currOperator == '-' && nextOperator != '*' && nextOperator != '/' && nextOperator != '(' && nextOperator != ')')
                {
                    sum = sum - nextNum;
                    currPosition = currPosition + 2;
                }
            }
            return sum;
        }

        static double CalculateMultDev(string input, int currPosition, double product = 1)
        {
            double currNum = double.Parse(input[currPosition].ToString());
            double nextNum = double.Parse(input[currPosition + 2].ToString());
            char currOperator = input[currPosition + 1];
            char nextOperator;
            if (currPosition + 3 < input.Length)
            {
                nextOperator = input[currPosition + 3];
            }
            else
            {
                nextOperator = ' ';
            }
            if (currOperator == '*')
            {
                product = currNum * nextNum;
            }
            else if (currOperator == '/')
            {
                product = currNum / nextNum;
            }
            else if (nextOperator == '*' || nextOperator == '/')
            {
                product = product * CalculateMultDev(input, currPosition + 2, product);
                currPosition = currPosition + 2;
            }
            return product;
        }
    }
}
