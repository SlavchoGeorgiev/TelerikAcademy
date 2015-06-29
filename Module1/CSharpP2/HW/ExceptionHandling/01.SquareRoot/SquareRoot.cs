using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            string input = Console.ReadLine();
            try
            {
                if (double.Parse(input) < 0)
                {
                    throw new ArgumentException() ;
                }
                Console.WriteLine(Math.Sqrt(double.Parse(input)));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
