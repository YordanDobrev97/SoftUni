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
            EnsureCreatedDatabase(db);

            var users = File.ReadAllText(Path + "/users.xml");
            var result = ImportUsers(db, users);
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
    }
}