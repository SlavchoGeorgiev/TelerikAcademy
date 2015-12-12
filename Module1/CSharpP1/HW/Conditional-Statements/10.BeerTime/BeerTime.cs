using System;
using System.Globalization;
using System.Threading;
//Problem 10.* Beer Time
//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator)
//and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
class BeerTime
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        DateTime inputTime;
        string pattern = "h:mm tt";
        Console.Write("Please enter a time in format \"hh:mm tt\":");
        string inputTimeAsString = Console.ReadLine();
        bool parseComplete = DateTime.TryParseExact(inputTimeAsString, pattern, CultureInfo.InvariantCulture, DateTimeStyles.None, out inputTime);
        if (inputTime.Hour >= 0 && inputTime.Hour <= 3)
        {
            inputTime = inputTime.AddDays(1);
        }
        if (parseComplete)
        {
            DateTime beerTimeStart = new DateTime();
            beerTimeStart = DateTime.ParseExact("01:00 PM", "hh:mm tt", CultureInfo.InvariantCulture);
            DateTime beerTimeEnd = new DateTime();
            beerTimeEnd = beerTimeStart.AddHours(14);
            if (inputTime >= beerTimeStart && inputTime < beerTimeEnd)
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
            Console.WriteLine(beerTimeStart);
            Console.WriteLine(beerTimeEnd);
            Console.WriteLine(inputTime);
        }
        else
        {
            Console.WriteLine("invalid time");
        }

    }
}
