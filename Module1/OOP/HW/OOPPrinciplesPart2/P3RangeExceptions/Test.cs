namespace P3RangeExceptions
{
    using System;

    class Test
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter integer number in the range [1-100] : ");
                int input = int.Parse(Console.ReadLine());
                TestIntRange(input);
            }
            catch (InvalidRangeException<int> ire)
            {
                Console.WriteLine("{0} Range is [{1}..{2}]", ire.Message, ire.Start, ire.End);
            }

            try
            {
                Console.Write("Enter date in the range [1.1.1980-31.12.2013] in format dd.mm.yyyy : ");
                string[] input = Console.ReadLine().Split(new char[] {' ', ',', '.', '-'}, StringSplitOptions.RemoveEmptyEntries);
                DateTime inputDate = new DateTime(int.Parse(input[2]), int.Parse(input[1]), int.Parse(input[0]));
                TestDateTimeRange(inputDate);
            }
            catch (InvalidRangeException<DateTime> ire)
            {
                Console.WriteLine("{0} Range is [{1:dd.MM.yyyy}..{2:dd.MM.yyyy}]", ire.Message, ire.Start, ire.End);
            }
        }

        private static void TestIntRange(int num)
        {
            const int rangeStart = 1;
            const int rangeEnd = 100;
            if (num > rangeEnd || num < rangeStart)
            {
                throw new InvalidRangeException<int>("Integer num out of range.", rangeStart, rangeEnd);
            }

            Console.WriteLine("TestIntRange(int num) completed wihtout exception.");
        }

        private static void TestDateTimeRange(DateTime date)
        {
            DateTime rangeStart = new DateTime(1980, 1, 1);
            DateTime rangeEnd = new DateTime(2013, 12, 31);
            if (date > rangeEnd || date < rangeStart)
            {
                throw new InvalidRangeException<DateTime>("DateTime of range.", rangeStart, rangeEnd);
            }

            Console.WriteLine("TestDateTimeRange(DateTime date) completed wihtout exception.");
        }
    }
}
