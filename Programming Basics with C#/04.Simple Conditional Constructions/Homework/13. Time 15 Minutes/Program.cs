using System;

namespace _13.Time_15_Minutes
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            minutes += 15;
            if (minutes > 59)
            {
                hour++;
                minutes -= 60;
            }

            if (hour > 23)
            {
                hour = 0;
            }


            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
            
        }
    }
}
