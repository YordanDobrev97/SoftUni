using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.HelloFrance
{
    class Program
    {
        static void Main()
        {
            var items = Console.ReadLine().Split("|").ToList();
            var budget = double.Parse(Console.ReadLine());
            var fullBudget = budget;

            List<double> newPrice = new List<double>();
            var maxPriceClothes = 50.00;
            var maxPriceShoes = 35.00;
            var maxPriceAccessories = 20.50;

            foreach (var item in items)
            {
                var args = item.Split("->");
                var type = args[0];
                var price = double.Parse(args[1]);

                switch (type)
                {
                    case "Clothes":
                        if (price <= maxPriceClothes && budget - price > 0)
                        {
                            budget -= price;
                            newPrice.Add(price);
                        }
                        break;
                    case "Shoes":
                        if (price <= maxPriceShoes && budget - price > 0)
                        {
                            budget -= price;
                            newPrice.Add(price);
                        }
                        break;
                    case "Accessories":
                        if (price <= maxPriceAccessories && budget - price> 0)
                        {
                            budget -= price;
                            newPrice.Add(price);
                        }
                        break;
                }
            }
            if (newPrice.Any())
            {
                newPrice = newPrice.Select(x => x + (x * 0.4)).ToList();
            }
            
            var sumPrice = newPrice.Sum() + budget;

            double profit = Math.Abs(sumPrice - fullBudget);

            if (newPrice.Count != 0)
            {
                foreach (var item in newPrice)
                {
                    Console.Write($"{item:f2} ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine($"Profit: {profit:f2}");

            if (sumPrice >= 150)
            {
                Console.WriteLine("Hello, France!");
            }
            else
            {
                Console.WriteLine("Time to go.");
            }
        }
    }
}
