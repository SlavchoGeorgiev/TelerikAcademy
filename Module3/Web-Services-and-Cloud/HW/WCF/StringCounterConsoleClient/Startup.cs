namespace StringCounterConsoleClient
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var service = new StringCounterClient();

            var result = service.GetCount("test", "sdf test sdfsdf test, proba test, test");
            Console.WriteLine(result);
        }
    }
}
