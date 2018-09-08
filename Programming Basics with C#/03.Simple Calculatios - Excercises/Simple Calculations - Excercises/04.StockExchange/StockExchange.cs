using System;

namespace _04.StockExchange
{
    class StockExchange
    {
        static void Main()
        {
            double pricePerWhiskey = double.Parse(Console.ReadLine());
            double quantityBeerLitters = double.Parse(Console.ReadLine());
            double quantityWineLitters = double.Parse(Console.ReadLine());
            double quantityRakiyaLitters = double.Parse(Console.ReadLine());
            double quantityWhiskeyLitters = double.Parse(Console.ReadLine());

            double pricePerRakiya = pricePerWhiskey / 2;
            double pricePerWine = pricePerRakiya - (0.4 * pricePerRakiya);//40%
            double pricePerBeer = pricePerRakiya - (0.8 * pricePerRakiya);//80%

            double sumRakiya = quantityRakiyaLitters * pricePerRakiya;
            double sumWine = quantityWineLitters * pricePerWine;
            double sumBeer = quantityBeerLitters * pricePerBeer;
            double sumWhiskey = quantityWhiskeyLitters * pricePerWhiskey;

            double totalSum = sumRakiya + sumWine + sumBeer + sumWhiskey;
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
