using System;
using System.Linq;
using System.Collections.Generic;
namespace _07.Vending_Machine
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            decimal totalCoins = 0M;
            decimal[] validCoins = new decimal[] { 0.1M, 0.2M, 0.5M, 1, 2 };
            var validProducts = new Dictionary<string, decimal>();

            validProducts["Nuts"] = 2.0M;
            validProducts["Water"] = 0.7M;
            validProducts["Crisps"] = 1.5M;
            validProducts["Soda"] = 0.8M;
            validProducts["Coke"] = 1.0M;

            while (input != "Start")
            {
                decimal coins = decimal.Parse(input);
                if (validCoins.Contains(coins))
                {
                    totalCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                input = Console.ReadLine();
            }

            string product = Console.ReadLine();

            while (true)
            {
                if (product == "End")
                {
                    break;
                }

                if (validProducts.ContainsKey(product))
                {
                    decimal value = validProducts[product];
                    if ((totalCoins - value) >= 0)
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        totalCoins -= value;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}
