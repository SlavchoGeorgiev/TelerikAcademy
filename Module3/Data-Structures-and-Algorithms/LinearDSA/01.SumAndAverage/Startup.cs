namespace _01.SumAndAverage
{
    using System;
    using System.Linq;

    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            var list = ColectionGenerator.GenerateList(Console.In);
            var sum = list.Sum();
            var average = sum / list.Count();

            Console.WriteLine($"Average: {average}, Sum: {sum}");
        }
    }
}
