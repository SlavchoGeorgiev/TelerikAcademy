namespace DayOfTheWeekConsoleClient
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var service = new DayOfWeekServiceReference.DayInBulgariaClient();

            Console.WriteLine(service.DayOfWeek(DateTime.Now));
        }
    }
}
