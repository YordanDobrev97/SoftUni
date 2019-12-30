using System;
using System.Globalization;

namespace _01.SoftuniCoffeeOrders
{
    class Program
    {
        static void Main()
        {
            int orderCount = int.Parse(Console.ReadLine());

            decimal totalPrice = 0;

            for (int i = 0; i < orderCount; i++)
            {
                decimal price = decimal.Parse(Console.ReadLine());
                DateTime day = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long countCapsule = long.Parse(Console.ReadLine());

                int countDay = DateTime.DaysInMonth(day.Year, day.Month);

                decimal currentPrice = (countDay * countCapsule) * price;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
