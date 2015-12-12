namespace TheDayOfTheWeek
{
    using System;
    using System.Globalization;

    public class DayInBulgaria : IDayInBulgaria
    {
        public string DayOfWeek(DateTime date)
        {
            var dayOfWeek = date.DayOfWeek;
            
            var cultureInfo = new CultureInfo("bg-BG");

            return cultureInfo.DateTimeFormat.GetDayName(dayOfWeek);
        }
    }
}
