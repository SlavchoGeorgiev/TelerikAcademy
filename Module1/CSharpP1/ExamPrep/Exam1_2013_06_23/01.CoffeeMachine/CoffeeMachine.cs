using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CoffeeMachine
{
    class CoffeeMachine
    {
        static void Main(string[] args)
        {
            decimal machineMoney = 0;
            machineMoney = machineMoney + (0.05m * decimal.Parse(Console.ReadLine()));
            machineMoney = machineMoney + (0.10m * decimal.Parse(Console.ReadLine()));
            machineMoney = machineMoney + (0.20m * decimal.Parse(Console.ReadLine()));
            machineMoney = machineMoney + (0.50m * decimal.Parse(Console.ReadLine()));
            machineMoney = machineMoney + (1.00m * decimal.Parse(Console.ReadLine()));
            //Console.WriteLine(machineMoney);
            decimal a = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            if (a < p)
            {
                Console.WriteLine("More {0:F2}", p - a);
            }
            else if (a - p <= machineMoney)
            {
                Console.WriteLine("Yes {0:F2}", machineMoney - (a - p));
            }
            else if (a - p > machineMoney)
            {
                Console.WriteLine("No {0:F2}", (a - p) - machineMoney);
            }
        }
    }
}
