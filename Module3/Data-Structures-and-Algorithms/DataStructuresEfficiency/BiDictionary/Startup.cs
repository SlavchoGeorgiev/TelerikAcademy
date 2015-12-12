namespace BiDictionary
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var biDictionary = new BiDictionary<int, int, string>();

            biDictionary.Add(1, 1, "Value 1")
                .Add(1, 2, "Value 2")
                .Add(1, 3, "Value 3")
                .Add(2, 1, "Value 4")
                .Add(2, 2, "Value 5")
                .Add(2, 3, "Value 6")
                .Add(3, 3, "Value 7")
                .Add(3, 4, "Value 8")
                .Add(3, 5, "Value 9")
                .Add(2, 1, "Value 10");

            var xKey = 2;
            Console.WriteLine("Values with keyX = {0} :\n\r {1}", xKey, string.Join(Environment.NewLine + " ", biDictionary.FindByXKey(xKey)));
            var yKey = 1;
            Console.WriteLine("Values with keyY = {0} :\n\r {1}", yKey, string.Join(Environment.NewLine + " ", biDictionary.FindByYKey(yKey)));
            Console.WriteLine("Values with keyX = {0} and keyY = {1} :\n\r {2}", xKey, yKey, string.Join(Environment.NewLine + " ", biDictionary.Find(xKey , yKey)));
        }
    }
}
