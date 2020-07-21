using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.Globalization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ProductShop
{
    public class StartUp
    {
        private const string Path = "../../../Datasets";

        public static void Main()
        {
            var db = new ProductShopContext();
            Mapper.Initialize(cng => cng.AddProfile(new ProductShopProfile()));
            var users = File.ReadAllText(Path + "/users.xml");
            var result = ImportUsers(db, users);
            Console.WriteLine(result);

            //EnsureCreatedDatabase(db);
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
            var root = new XmlRootAttribute("Users");
            var serializer = new XmlSerializer(typeof(ImportUserDTO[]), root);

            using (var reader = new StringReader(inputXml))
            {
                var users = (ImportUserDTO[])serializer.Deserialize(reader);

                foreach (var userDTO in users)
                {
                    var user = Mapper.Map<User>(userDTO);
                    context.Users.Add(user);
                }
            }

            int usersCount = context.SaveChanges();

            return $"Successfully imported {usersCount}";
        }
    }
}