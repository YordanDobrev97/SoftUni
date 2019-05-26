using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main()
        {
            int startingYield = int.Parse(Console.ReadLine());

            int days = 0;
            int workers = 26;
            int drop = 10;
            int leaving = 0;

            while (startingYield >= 100)
            {
                days++;
                leaving += startingYield - workers;
                startingYield -= drop;
            }

            if (leaving != 0)
            {
                leaving -= workers;
            }

            Console.WriteLine(days);
            Console.WriteLine(leaving);
        }
    }
}
