using System;

namespace _12.Volleyball
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine();
            int numberHolidays = int.Parse(Console.ReadLine());
            int numberWeekends = int.Parse(Console.ReadLine());

            int numberWeekendsInYear = 48;

            double numberPlaysWeekends = numberWeekendsInYear - numberWeekends;
            double numberPlayHomeCity = numberWeekendsInYear - numberPlaysWeekends;

            numberPlaysWeekends = numberPlaysWeekends * 3 / 4.0;


            double holidays = numberHolidays * 2 / 3.0;
            double totalPlays = numberPlaysWeekends + numberPlayHomeCity + holidays;

            if (year == "leap")
            {
                totalPlays = totalPlays + (totalPlays * 0.15);
            }

            Console.WriteLine(Math.Truncate(totalPlays));
        }
    }
}
