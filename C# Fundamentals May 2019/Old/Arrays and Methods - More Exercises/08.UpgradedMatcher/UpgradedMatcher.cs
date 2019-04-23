using System;
using System.Linq;

namespace _08.UpgradedMatcher
{
    class UpgradedMatcher
    {
        static void Main()
        {

            string[] nameProducts = Console.ReadLine()
                .Split();

            long[] quantities = Console.ReadLine()
                .Split()
                .Select(long.Parse)
                .ToArray();

            decimal[] prices = Console.ReadLine()
                .Split()
                .Select(decimal.Parse)
                .ToArray();

            string line = Console.ReadLine();

            while (line != "done")
            {
                string nameProduct = line.Split()[0];
                int quantity = int.Parse(line.Split()[1]);

                if (nameProducts.Contains(nameProduct))
                {
                    int index = Array.IndexOf(nameProducts, nameProduct);
                    decimal price = prices[index] * quantity;
                    long getQuantity = 0;

                    if (index < quantities.Length - 1)
                    {
                        getQuantity = quantities[index];
                    }

                    if (quantity <= getQuantity)
                    {
                        quantities[index] -= quantity;
                        Console.WriteLine($"{nameProduct} x {quantity} costs {price:f2}");
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {nameProduct}");
                    }
                }

                line = Console.ReadLine();
            }
        }
    }
}
