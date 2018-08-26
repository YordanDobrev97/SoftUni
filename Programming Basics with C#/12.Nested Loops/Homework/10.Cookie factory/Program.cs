using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Cookie_factory
{
    class Program
    {
        static void Main()
        {
            var batches = int.Parse(Console.ReadLine());

            var numberMatches = 0;
            List<string> products = new List<string>();
            while (numberMatches < batches)
            {
                var product = Console.ReadLine();
                if (product == "Bake!")
                {
                    if (Success(products))
                    {
                        numberMatches++;
                        Console.WriteLine($"Baking batch number {numberMatches}...");
                        products.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"The batter should contain flour, eggs and sugar!");
                    }
                }
                else
                {
                    products.Add(product);
                }
            }
        }

        private static bool Success(List<string> products)
        {
            if (products.Contains("flour") && 
                products.Contains("eggs")  &&
                products.Contains("sugar"))
            {
                return true;
            }
            return false;
        }
    }
}
