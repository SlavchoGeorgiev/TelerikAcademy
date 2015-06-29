using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int rangeBegin = 1;
            int rangeEnd = 100;
            Console.WriteLine("Please enter ten number in range  {0} <= NUMBER <= {1} \nand every nex shout be bigger", rangeBegin, rangeEnd);
            ReadNumber(rangeBegin, rangeEnd);
        }

        private static void ReadNumber(int rangeBegin, int rangeEnd)
        {
            int lastNum = 0;
            for (int i = 0; i < 10; i++)
            {
                int newNum = 0; ;
                try
                {
                    newNum = int.Parse(Console.ReadLine());

                    if (newNum < rangeBegin || newNum > rangeEnd)
                    {
                        throw new ArgumentOutOfRangeException("Out of Range");
                    }
                    if (newNum <= lastNum)
                    {
                        throw new ArgumentOutOfRangeException("Is not bigger");
                    }
                    lastNum = newNum;

                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not number!");
                    i--;
                }
                catch (ArgumentOutOfRangeException aoore)
                {
                    i--;
                    if (aoore.ParamName == "Out of Range")
                    {
                        Console.WriteLine("{0} is out of range!", newNum);
                    }
                    else if (aoore.ParamName == "Is not bigger")
                    {
                        Console.WriteLine("{0} is not bigger!", newNum);
                    }
                }
            }
        }
    }
}
