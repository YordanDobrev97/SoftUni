using System;
using System.Linq;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
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
                string nameProduct = line;

                if (nameProducts.Contains(nameProduct))
                {
                    int index = Array.IndexOf(nameProducts, nameProduct);
                    Console.WriteLine($"{nameProducts[index]} costs: {prices[index]}; " +
                        $"Available quantity: {quantities[index]}");
                }

                line = Console.ReadLine();
            }
        }
    }
}
