using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateDifference
{
    class DateDifference
    {
        static void Main()
        {
            Console.WriteLine("Enter the first date: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("BG"));
            Console.WriteLine("Enter the second date: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine(), new CultureInfo("BG"));
            TimeSpan days = secondDate - firstDate;
            StringBuilder span = new StringBuilder();
            int i = 0;
            while (days.ToString()[i] != '.')
            {
                span.Append(days.ToString()[i]);
                i++;
            }
            int numberOfDays = Math.Abs(int.Parse(span.ToString()));
            Console.WriteLine("Distance: {0}", numberOfDays);
        }
    }
}
