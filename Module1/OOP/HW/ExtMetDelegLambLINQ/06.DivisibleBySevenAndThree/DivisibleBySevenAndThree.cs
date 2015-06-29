namespace _06.DivisibleBySevenAndThree
{
    using System;
    using System.Linq;

    class DivisibleBySevenAndThree
    {
        static void Main()
        {
            int[] arrayOfInt = { 3, 6, 7, 14, 25, 21, 18, 42, 63 };
            var divArr = arrayOfInt.Where(i => i % 3 == 0 && i % 7 == 0);
            foreach (var num in divArr)
            {
                Console.WriteLine(num);
            }

            var divArrAnatherWay = from num in arrayOfInt where num % 3 == 0 && num % 7 == 0 select num;
            Console.WriteLine();
            foreach (var num in divArrAnatherWay)
            {
                Console.WriteLine(num);
            }
        }
    }
}
