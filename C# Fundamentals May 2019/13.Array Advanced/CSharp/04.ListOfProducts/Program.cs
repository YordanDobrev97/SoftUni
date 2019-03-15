using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main()
        {
            int numberProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();
            for (int i = 0; i < numberProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products = products.OrderBy(x => x)
                .ToList();

            int number = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{number}.{product}");
                number++;
            }
        }
    }
}
