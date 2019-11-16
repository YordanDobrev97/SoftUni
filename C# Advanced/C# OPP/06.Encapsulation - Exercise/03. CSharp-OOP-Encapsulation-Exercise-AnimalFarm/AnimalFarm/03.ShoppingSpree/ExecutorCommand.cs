using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class ExecutorCommand
    {
        public void Execute(string[] persons, string[] products)
        {
            try
            {
                List<Person> listPerson = new List<Person>();
                List<Product> productsInput = new List<Product>();

                ProcessPersonInput(listPerson, persons);
                ProcessProductsInput(productsInput, products);

                while (true)
                {
                    string command = Console.ReadLine();

                    if (command == "END")
                    {
                        break;
                    }

                    string[] parts = command.Split();
                    string name = parts[0];
                    string product = parts[1];

                    Person currentPerson = Person.GetCurrentPerson(name, listPerson);
                    Product currentProduct = Person.GetCurrentProduct(product, productsInput);

                    if (Person.Buy(currentPerson, currentProduct))
                    {
                        Console.WriteLine($"{name} bought {product}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} can't afford {product}");
                    }
                }

                foreach (var person in listPerson)
                {
                    if (person.Products.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought ");
                    }
                    else
                    {
                        var allProducts = person.Products;
                        Console.Write($"{person.Name} - ");

                        int index = 0;
                        foreach (var item in allProducts)
                        {
                            if (index == allProducts.Count - 1)
                            {
                                Console.Write($"{item.Name}");
                            }
                            else
                            {
                                Console.Write($"{item.Name}, ");
                            }
                            index++;
                        }

                        Console.WriteLine();
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private static void ProcessProductsInput(List<Product> productsInput, string[] products)
        {
            foreach (var product in products)
            {
                string[] items = product.Split('=');
                string name = items[0];
                decimal cost = decimal.Parse(items[1]);
                Product currentProduct = new Product(name, cost);
                productsInput.Add(currentProduct);
            }
        }

        private static void ProcessPersonInput(List<Person> persons, string[] personData)
        {
            foreach (var person in personData)
            {
                string[] personItems = person.Split('=');
                string name = personItems[0];
                decimal money = decimal.Parse(personItems[1]);
                var newPerson = new Person(name, money);
                persons.Add(newPerson);
            }
        }
    }
}
