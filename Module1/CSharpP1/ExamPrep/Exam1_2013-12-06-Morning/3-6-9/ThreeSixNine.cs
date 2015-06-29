using System;
class ThreeSixNine
{
    static void Main()
    {
        ulong a = ulong.Parse(Console.ReadLine());
        ulong b = ulong.Parse(Console.ReadLine());
        ulong c = ulong.Parse(Console.ReadLine());
        if (b == 3)
        {
            if ((a + c) % 3 == 0)
            {
                Console.WriteLine((a + c) / 3);
            }
            else
            {
                Console.WriteLine((a + c) % 3);
            }
            Console.WriteLine(a + c);
        }
        else if (b == 6)
        {
            if ((a * c) % 3 == 0)
            {
                Console.WriteLine((a * c) / 3);
            }
            else
            {
                Console.WriteLine((a * c) % 3);
            }
            Console.WriteLine(a * c);
        }
        else if (b == 9)
        {
            if ((a % c) % 3 == 0)
            {
                Console.WriteLine((a % c) / 3);
            }
            else
            {
                Console.WriteLine((a % c) % 3);
            }
            Console.WriteLine(a % c);
        }
    }
}
