using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class DiamondTrolls
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            //firstLine
            string line = "";
            line = new string('.', (width - n) / 2);
            line = line + new string('*', n);
            line = line + new string('.', (width - n) / 2);
            Console.WriteLine(line);
            //nextLine
            for (int i = n / 2 ; i > 0; i--)
            {
                line = new string('.', i);
                line = line + '*';
                line = line + new string('.', n - 1 - i);
                line = line + '*';
                line = line + new string('.', n - 1 - i);
                line = line + '*';
                line = line + new string('.', i);
                Console.WriteLine(line);
            }
            //nextLine
            Console.WriteLine(new string('*', width));
            //NextLine
            for (int i = 1; i <= n - 1; i++)
            {
                line = new string('.', i);
                line = line + '*';
                line = line + new string('.', n - 1 - i);
                line = line + '*';
                line = line + new string('.', n - 1 - i);
                line = line + '*';
                line = line + new string('.', i);
                Console.WriteLine(line);
            }
            line = new string('.', n);
            line = line + '*';
            line = line + new string('.', n);
            Console.WriteLine(line);
        }
    }
}
