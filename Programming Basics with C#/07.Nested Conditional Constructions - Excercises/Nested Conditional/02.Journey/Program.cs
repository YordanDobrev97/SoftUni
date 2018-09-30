using System;

namespace _02.Journey
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", budget * 0.30);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.70);
                }
            }
            else if(budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine("Camp - {0:f2}", budget * 0.40);
                }
                else
                {
                    Console.WriteLine("Hotel - {0:f2}", budget * 0.80);
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}", budget * 0.90);
            }
        }
    }
}
