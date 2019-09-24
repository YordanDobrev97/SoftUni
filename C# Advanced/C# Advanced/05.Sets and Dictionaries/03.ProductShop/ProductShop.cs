using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    public class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name{ get; set; }

        public double Price { get; set; }
    }

    public class ProductShop
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            var products = new SortedDictionary<string, List<Product>>();

            while (input != "Revision")
            {
                string[] elements = input.Split(", ");
                string shop = elements[0];
                string product = elements[1];
                double price = double.Parse(elements[2]);

                Product currentProduct = new Product(product, price);

                if (!products.ContainsKey(shop))
                {
                    products.Add(shop, new List<Product>());
                }

                products[shop].Add(currentProduct);

                input = Console.ReadLine();
            }

            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key}->");

                foreach (var product in item.Value)
                {
                    Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
                }
            }
        }
    }
}
