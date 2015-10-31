namespace _03.ListSort
{
    using System;
    using Helpers;

    public class Startup
    {
        public static void Main()
        {
            var list = ColectionGenerator.GenerateList(Console.In);
            list.Sort();
            list.ForEach(x => Console.Write("{0} ", x));
        }
    }
}
