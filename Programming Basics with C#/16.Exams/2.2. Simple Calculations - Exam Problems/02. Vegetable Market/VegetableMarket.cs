using System;

namespace _02.Vegetable_Market
{
    class VegetableMarket
    {
        static void Main()
        {
            double pricePerKillosVegetable = double.Parse(Console.ReadLine());
            double pricePerKillosFruits = double.Parse(Console.ReadLine());
            int totalKillosPerVegetables = int.Parse(Console.ReadLine());
            int totalKillosPerFruits = int.Parse(Console.ReadLine());

            double vegetablesPrice = pricePerKillosVegetable * totalKillosPerVegetables;
            double fruitsPrice = pricePerKillosFruits * totalKillosPerFruits;

            double total = vegetablesPrice + fruitsPrice;
            double euro = total / 1.94;

            Console.WriteLine(euro);
        }
    }
}
