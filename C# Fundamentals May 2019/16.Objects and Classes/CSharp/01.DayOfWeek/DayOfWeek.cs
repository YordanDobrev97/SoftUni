using System;
using System.Globalization;

namespace _01.DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            string data = Console.ReadLine();
            DateTime parseData = DateTime.ParseExact(data, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var dayOfWeek = parseData.DayOfWeek;
            Console.WriteLine(dayOfWeek);
        }
    }
}
