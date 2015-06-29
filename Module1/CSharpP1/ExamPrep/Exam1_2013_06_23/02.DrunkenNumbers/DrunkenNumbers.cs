using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.DrunkenNumbers
{
    class DrunkenNumbers
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            ulong mBeers = 0;
            ulong vBeers = 0;
            string input = "";
            for (ulong i = 0; i < n; i++)
            {
                input = Console.ReadLine();
               
                //char[] separators = {'0', ' '};
                //string[] inputSign = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                //string inputCleaned = "";
                //for (int index = 0; index < inputSign.Length; index++)
                //{
                //    inputCleaned = inputCleaned + inputSign[index];
                //}
                //input = inputCleaned;

                long inputAsInt = long.Parse(input);
                inputAsInt = Math.Abs(inputAsInt);
                input = inputAsInt.ToString();

                if (input.Length % 2 == 0)
                {
                    for (int index = 0; index < input.Length / 2; index++)
                    {
                        mBeers = mBeers + ulong.Parse(input[index].ToString());
                    }
                    for (int index = input.Length / 2; index < input.Length; index++)
                    {
                        vBeers = vBeers + ulong.Parse(input[index].ToString());
                    }
                }
                else
                {
                    for (int index = 0; index <= input.Length / 2; index++)
                    {
                        mBeers = mBeers + ulong.Parse(input[index].ToString());
                    }
                    for (int index = input.Length / 2; index < input.Length; index++)
                    {
                        vBeers = vBeers + ulong.Parse(input[index].ToString());
                    }
                }
            }
            if (mBeers > vBeers)
            {
                Console.WriteLine("M {0}", mBeers - vBeers);
            }
            else if (vBeers > mBeers)
            {
                Console.WriteLine("V {0}", vBeers - mBeers);
            }
            else
            {
                Console.WriteLine("No {0}", mBeers + vBeers);
            }
        }
    }
}
