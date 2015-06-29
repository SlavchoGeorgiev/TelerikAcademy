using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichaniaBoats
{
    class KaspichaniaBoats
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string line = "";
            line = line + new string('.', n);
            line = line + "*";
            line = line + new string('.', n);
            Console.WriteLine(line);
            for (int i = 0; i < n - 1; i++)
            {
                line = new string('.', n - 1 - i);
                line = line + "*";
                line = line + new string('.', i);
                line = line + "*";
                line = line + new string('.', i);
                line = line + "*";
                line = line + new string('.', n - 1 - i);
                Console.WriteLine(line);
            }
            Console.WriteLine(new string('*', n * 2 + 1));
            for (int i = n - 2; i >= n / 2; i--)
            {
                line = new string('.', n - 1 - i);
                line = line + "*";
                line = line + new string('.', i);
                line = line + "*";
                line = line + new string('.', i);
                line = line + "*";
                line = line + new string('.', n - 1 - i);
                Console.WriteLine(line);
            }
            line = new string('.', n / 2 + 1);
            line = line + new string('*', n);
            line = line + new string('.', n / 2 + 1);
            Console.WriteLine(line);
        }
    }
}