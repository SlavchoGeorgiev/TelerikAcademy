using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression
{
    class Expression
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine("{0:F2}", Result(input, input.Length - 1));
        }
        static double Result(string input, int endPosition, int startPosition = 0)
        {
            double currSubTotal;
            if (input[startPosition] == '-')
            {
                if (input[startPosition + 1] == '(')
                {
                    int endBracketPosition = 0;
                    currSubTotal = -1 * CalculateInBrackets(input, startPosition + 1, out endBracketPosition);
                    startPosition = endBracketPosition;
                }
                else
                {
                    currSubTotal = -1 * double.Parse(input[startPosition + 1].ToString());
                    startPosition++;
                }
            }
            else if (input[startPosition] == '(')
            {
                int endBracketPosition = 0;
                currSubTotal = CalculateInBrackets(input, startPosition, out endBracketPosition);
                startPosition = endBracketPosition;
            }
            else
            {
                currSubTotal = double.Parse(input[startPosition].ToString());
            }
            for (int i = startPosition; i < endPosition - 2; i = i + 2)
            {
                if (input[i] == '-')
                {
                    i++;
                }
                if (input[i + 2] != '(')
                {
                    double nextDigit = double.Parse(input[i + 2].ToString());
                    char expresion = input[i + 1];
                    currSubTotal = Calculate(currSubTotal, nextDigit, expresion);
                }
                else
                {
                    char expresion = input[i + 1];
                    currSubTotal = Calculate(currSubTotal, CalculateInBrackets(input, i + 2, out i), expresion);
                    i = i - 2;
                }
            }
            return currSubTotal;
        }

        static double CalculateInBrackets(string input, int bracketPosition, out int endBracketPositio)
        {
            for (int i = bracketPosition; true; i++)
            {
                if (input[i] == ')')
                {
                    endBracketPositio = i;
                    break;
                }
            }
            return Result(input, endBracketPositio, bracketPosition + 1);
        }
        static double Calculate(double numOne, double numTow, char expresion)
        {
            if (expresion == '+')
            {
                return numOne + numTow;
            }
            else if (expresion == '-')
            {
                return numOne - numTow;
            }
            else if (expresion == '*')
            {
                return numOne * numTow;
            }
            else if (expresion == '/')
            {
                return numOne / numTow;
            }
            else
            {
                return 0;
            }
        }
    }
}
