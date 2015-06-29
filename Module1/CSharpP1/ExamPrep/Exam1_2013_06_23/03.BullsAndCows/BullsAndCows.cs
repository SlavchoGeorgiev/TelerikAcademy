using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BullsAndCows
{
    class BullsAndCows
    {
        static void Main(string[] args)
        {
            int secretNumber = Math.Abs(int.Parse(Console.ReadLine()));
            string secNumAsString = secretNumber.ToString();
            int bulls = Math.Abs(int.Parse(Console.ReadLine()));
            int cows = Math.Abs(int.Parse(Console.ReadLine()));
            bool isCombinations = false;
            for (int tryNumber = 1000; tryNumber <= 9999; tryNumber++)
            {
                int currBulls = 0;
                int currCows = 0;
                string tryNumAsString = tryNumber.ToString();
                string conteinedDigits = "";
                if (tryNumAsString[1] != '0' && tryNumAsString[2] != '0' && tryNumAsString[3] != '0')
                {
                    //BullsCheck
                    for (int index = 0; index < 4; index++)
                    {
                        if (secNumAsString[index] == tryNumAsString[index])
                        {
                            currBulls++;
                        }
                    }
                    //CowCheck
                    for (int tryIndex = 0; tryIndex < 4; tryIndex++)
                    {
                        for (int secIndex = 0; secIndex < 4; secIndex++)
                        {
                            if (secNumAsString[secIndex] != tryNumAsString[secIndex] &&
                                secNumAsString[tryIndex] != tryNumAsString[tryIndex] &&
                                secNumAsString[secIndex] == tryNumAsString[tryIndex] &&
                                !conteinedDigits.Contains(secNumAsString[secIndex]))
                            {
                                currCows++;
                                conteinedDigits = conteinedDigits + secNumAsString[secIndex];
                            }
                        }
                    }
                    if (currCows == cows && currBulls == bulls)
                    {
                        Console.Write("{0} ", tryNumber);
                        isCombinations = true;
                    }
                }
            }
            if (!isCombinations)
            {
                Console.WriteLine("No");
            }
        }
    }
}
