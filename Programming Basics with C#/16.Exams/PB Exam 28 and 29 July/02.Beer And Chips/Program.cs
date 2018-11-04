using System;

namespace _02.Beer_And_Chips
{
    class Program
    {
        static void Main()
        {
            double priceBeer = 1.20;
            string nameFan = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beers = int.Parse(Console.ReadLine());
            int chips = int.Parse(Console.ReadLine());

            double totalPriceBeer = priceBeer * beers;
            double priceChips = totalPriceBeer * 0.45;

            double totalPriceChips = Math.Ceiling(priceChips * chips);

            double totalSum = totalPriceBeer + totalPriceChips;

            if (totalSum <= budget)
            {
                Console.WriteLine("{0} bought a snack and has {1:f2} leva left.", nameFan, budget - totalSum);
            }
            else
            {
                Console.WriteLine("{0} needs {1:f2} more leva!", nameFan, totalSum - budget);
            }
        }
    }
}
