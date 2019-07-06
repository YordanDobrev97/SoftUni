using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Orders
{
    class Orders
    {
        static void Main()
        {
            var line = Console.ReadLine();

            var products = new Dictionary<string, Dictionary<double, int>>();
            while (line != "buy")
            {
                string[] elements = line.Split(" ");
                string product = elements[0];
                double price = double.Parse(elements[1]);
                int quantity = int.Parse(elements[2]);

                double totalPrice = price * quantity;

                if (!products.ContainsKey(product))
                {
                    products.Add(product, new Dictionary<double, int>());
                    products[product].Add(price, quantity);
                }
                else
                {
                    var key = products[product].Keys.ToList()[0];
                    var increasingQuantity = products[product][key] + quantity;
                    products[product] = new Dictionary<double, int>();
                    products[product].Add(price, increasingQuantity);
                }

                line = Console.ReadLine();
            }

            foreach (var product in products)
            {
                var currentProduct = product.Key;
                var totalPrice = product.Value.Keys.First() * product.Value.Values.First();

                Console.WriteLine($"{currentProduct} -> {totalPrice:f2}");
            }
        }
    }
}
