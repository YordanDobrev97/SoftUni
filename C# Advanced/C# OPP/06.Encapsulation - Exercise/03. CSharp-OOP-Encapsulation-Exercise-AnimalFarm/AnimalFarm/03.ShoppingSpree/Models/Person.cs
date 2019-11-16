using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> products;

        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.products = new List<Product>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public List<Product> Products
        {
            get
            {
                return this.products;
            }
        }

        public static Person GetCurrentPerson(string name, List<Person> persons)
        {
            var person = persons.Where(x => x.Name == name).FirstOrDefault();
            return person;
        }

        public static Product GetCurrentProduct(string product, List<Product> products)
        {
            var currentProduct = products.Where(x => x.Name == product).FirstOrDefault();
            return currentProduct;
        }

        public static bool Buy(Person currentPerson, Product currentProduct)
        {
            decimal personMoney = currentPerson.Money;
            decimal productMoney = currentProduct.Cost;

            if (personMoney - productMoney >= 0)
            {
                currentPerson.Money -= productMoney;
                currentPerson.Products.Add(currentProduct);
                return true;
            }

            return false;
        }
    }
}
