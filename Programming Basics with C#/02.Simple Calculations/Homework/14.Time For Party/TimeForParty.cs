using System;
using System.Globalization;

class TimeForParty
{
    static void Main()
    {
        string data = Console.ReadLine();

        var parseData = DateTime.ParseExact(data,
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);

        var day = parseData.DayOfWeek.ToString();

        if (day != "Friday" && day != "Saturday")
        {
            Console.WriteLine($"No party tonight! Today is: {day}");
        }
        else
        {
            Console.WriteLine($"Party night! Today is: {day}");
        }
    }
}
