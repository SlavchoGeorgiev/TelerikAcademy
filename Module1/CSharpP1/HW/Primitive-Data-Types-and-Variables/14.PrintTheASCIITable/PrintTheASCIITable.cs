using System;

class PrintTheASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.Write((char)i);
            if (i % 25 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
