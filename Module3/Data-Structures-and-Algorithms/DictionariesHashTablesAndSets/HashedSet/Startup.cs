namespace HashedSet
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var hashedSet = new HashedSet<string>();

            hashedSet.Add("Alex")
                .Add("Pesho")
                .Add("Pesho")
                .Add("Pesho")
                .Add("Pesho")
                .Add("Pesho")
                .Add("Pesho")
                .Add("Hrist");

            Console.WriteLine(string.Join(" ", hashedSet));
        }
    }
}
