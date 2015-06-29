using System;

class AgeCalculator
{
    static void Main()
    {
        System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("bg-BG");
        int dayOfBirth;
        int monthOfBirth;
        int yearOfBirth;
        int yearsOld;
        DateTime birthDate;
        bool exit = false;
        while (!exit)
        {
            #region
            try
            {
                Console.WriteLine("Entet your birth day, month and year.");
                Console.Write("DAY : ");
                dayOfBirth = int.Parse(Console.ReadLine());
                Console.Write("MONTH : ");
                monthOfBirth = int.Parse(Console.ReadLine());
                Console.Write("YEAR : ");
                yearOfBirth = int.Parse(Console.ReadLine());
                birthDate = new DateTime(yearOfBirth, monthOfBirth, dayOfBirth);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Date :(");
                return;
            }
            Console.WriteLine("Your birth date is: {0}", birthDate.Date);
            yearsOld = YearOld(birthDate);
            Console.WriteLine("You are {0} year old.", yearsOld);
            Console.WriteLine("Afther 10 years you will be {0} years old.", yearsOld + 10);
            Console.WriteLine("Press \"X\" for exit.");
            if (Console.ReadKey().Key == System.ConsoleKey.X)
            {
                exit = true;
            }

            #endregion
        }
    }
    static int YearOld(DateTime birthDate)
    {
        int yearsOld = DateTime.Now.Year - birthDate.Year;
        if (DateTime.Now.Month < birthDate.Month || (DateTime.Now.Month == birthDate.Month && DateTime.Now.Day < birthDate.Day))
        {
            yearsOld = yearsOld - 1;
        }
        if (DateTime.Now.Day == birthDate.Day && DateTime.Now.Month == birthDate.Month)
        {
            Console.WriteLine("Happy birthday!");
        }
        else if (yearsOld <= 0 || yearsOld > 150)
        {
            Console.WriteLine("Liar this is imposible :p");
        }

        return yearsOld;
    }
}
