using Microsoft.EntityFrameworkCore;
using P03_SalesDatabase.Data;
using P03_SalesDatabase.Data.Models;
using System;
using System.Linq;

namespace P03_SalesDatabase
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new SalesContext();
            db.Database.Migrate();

            db.Sales.Add(new Sale()
            {
                Customer = new Customer()
                {
                    Name = "Pesho"
                },
                Product = new Product()
                {
                    Name = "kartofi"
                },
                Store = new Store()
                {
                    Name = "Sofia"
                }
            });

            db.SaveChanges();

            Console.WriteLine(db.Sales.Count());
        }
    }
}