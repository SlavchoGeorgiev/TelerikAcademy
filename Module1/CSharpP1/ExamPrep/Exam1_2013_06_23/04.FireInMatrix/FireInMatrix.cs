using System;
class FireInMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int row = 1; row <= n / 2; row++)
        {
            string line = new string('.', n / 2 - row);
            line = line + "#";
            line = line + new string('.', (row - 1) * 2);
            line = line + "#";
            line = line + new string('.', n / 2 - row);
            Console.WriteLine(line);
        }
        for (int row = n / 2; row > n / 4; row--)
        {
            string line = new string('.', n / 2 - row);
            line = line + "#";
            line = line + new string('.', (row - 1) * 2);
            line = line + "#";
            line = line + new string('.', n / 2 - row);
            Console.WriteLine(line);
        }
        Console.WriteLine(new string('-', n));
        for (int row = 0; row < n / 2; row++)
        {
            string line = new string('.', row);
            line = line + new string('\\', n / 2 - row);
            line = line + new string('/', n / 2 - row);
            line = line + new string('.', row);
            Console.WriteLine(line);
        }

    }
}
