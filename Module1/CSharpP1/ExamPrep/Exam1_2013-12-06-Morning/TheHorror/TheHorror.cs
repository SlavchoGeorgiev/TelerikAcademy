using System;

namespace TheHorror
{
    class TheHorror
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int currDigit = 0;
            int count = 0;
            ulong sum = 0;
            for (int index = 0; index < input.Length; index++)
            {
                if (!int.TryParse(input[index].ToString(), out currDigit))
                {
                    continue;
                }
                if (index % 2 == 0)
                {
                    count++;
                    sum = sum + (ulong)currDigit;
                }
            }
            Console.WriteLine("{0} {1}", count, sum);
            //Main();
        }
    }
}
