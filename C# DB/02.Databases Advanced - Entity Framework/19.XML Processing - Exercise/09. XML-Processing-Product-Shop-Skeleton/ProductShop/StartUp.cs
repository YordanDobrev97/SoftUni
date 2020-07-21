using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using XmlFacade;

namespace ProductShop
{
    public class StartUp
    {
        private const string Path = "../../../Datasets";

        public static void Main()
        {
            var db = new ProductShopContext();
            //EnsureCreatedDatabase(db);

            var users = File.ReadAllText(Path + "/products.xml");
            var result = ImportProducts(db, users);
            Console.WriteLine(result);
        }

        public static void EnsureCreatedDatabase(ProductShopContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            Console.WriteLine("Successfully created!");
        }

        //01.ImportUsers
        public static string ImportUsers(ProductShopContext context, string inputXml)
        {
            var root = "Users";
            var data = XmlConverter.Deserializer<ImportUserDTO>(inputXml, root);

            var users = data.Select(x => new User
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age
            })
            .ToArray();

            context.Users.AddRange(users);
            context.SaveChanges();
            return $"Successfully imported {users.Length}";
        }

        //02.ImportProducts
        public static string ImportProducts(ProductShopContext context, string inputXml)
        {
            var root = "Products";
            var data = XmlConverter.Deserializer<ImportProductDTO>(inputXml, root);

            var products = data.Select(x => new Product
            {
                Name = x.Name,
                Price = x.Price,
                SellerId = x.SellerId,
                BuyerId = x.BuyerId
            })
             .ToArray();

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }
    }
}