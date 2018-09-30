using System;

namespace _01.OnTimeForExam
{
    class Program
    {
        static void Main()
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesPerExam = int.Parse(Console.ReadLine());
            int hourPerArrival = int.Parse(Console.ReadLine());
            int minutesPerArrival = int.Parse(Console.ReadLine());

            int totalMinutesPerExam = hourExam * 60 + minutesPerExam;
            int totalMinutesPerArrival = hourPerArrival * 60 + minutesPerArrival;

            int diff = totalMinutesPerExam - totalMinutesPerArrival;

            int diffHour = 0;
            if (diff == 0 || diff > 0 && diff <= 30)
            {
                Console.WriteLine("On time");

                if (diff != 0)
                {
                    Console.WriteLine("{0} minutes before the start", diff);
                }
            }
            else if(diff > 30)
            {
                Console.WriteLine("Early");

                while (diff > 59)
                {
                    diffHour++;
                    diff -= 60;
                }

                if (diffHour > 0)
                {
                    Console.WriteLine("{0} {1:00} hours before the start", diffHour, diff);
                }
                else
                {
                    Console.WriteLine("{0} minutes before the start", diff);
                }
            }
            else
            {
                Console.WriteLine("Late");

                diff = Math.Abs(diff);

                while (diff > 59)
                {
                    diffHour++;
                    diff -= 60;
                }

                if (diffHour > 0)
                {
                    Console.WriteLine("{0} {1:00} hours after the start", diffHour, diff);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", diff);
                }
            }
        }
    }
}
