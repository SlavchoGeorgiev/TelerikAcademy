using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong a = ulong.Parse(Console.ReadLine());
            ulong b = ulong.Parse(Console.ReadLine());
            ulong c = ulong.Parse(Console.ReadLine());
            if (b == 2)
            {
                if ((a % c) % 4 == 0)
                {
                    Console.WriteLine((a % c) / 4);
                }
                else
                {
                    Console.WriteLine((a % c) % 4);
                }
                Console.WriteLine(a % c);
            }
            else if (b == 4)
            {
                if ((a + c) % 4 == 0)
                {
                    Console.WriteLine((a + c) / 4);
                }
                else
                {
                    Console.WriteLine((a + c) % 4);
                }
                Console.WriteLine(a + c);
            }
            else if (b == 8)
            {
                if ((a * c) % 4 == 0)
                {
                    Console.WriteLine((a * c) / 4);
                }
                else
                {
                    Console.WriteLine((a * c) % 4);
                }
                Console.WriteLine(a * c);
            }
        }
    }
}
