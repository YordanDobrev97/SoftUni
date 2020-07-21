using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Import;
using ProductShop.Models;
using System;
using System.Collections.Generic;
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

            var users = File.ReadAllText(Path + "/categories-products.xml");
            var result = ImportCategoryProducts(db, users);
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

        //03.ImportCategories
        public static string ImportCategories(ProductShopContext context, string inputXml)
        {
            var root = "Categories";
            var data = XmlConverter.Deserializer<ImportCategoryDTO>(inputXml, root);

            var categories = data.Select(x => new Category
            {
                Name = x.Name
            })
             .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }

        //04.ImportCategoryProducts
        public static string ImportCategoryProducts(ProductShopContext context, string inputXml)
        {
            var root = "CategoryProducts";
            var data = XmlConverter.Deserializer<ImportCategoryProductDTO>(inputXml, root);

            //var categoryProducts = data.Select(x => new CategoryProduct
            //{
            //    CategoryId = x.CategoryId,
            //    ProductId = x.ProductId
            //})
            //.ToArray();

            var categories = data.Select(x => new CategoryProduct
            {
                CategoryId = x.CategoryId,
                ProductId = x.ProductId
            })
            .ToArray();

            List<CategoryProduct> categoryProducts = new List<CategoryProduct>();
            foreach (var item in categories)
            {
                var existCategory = context.Categories.Any(x => x.Id == item.CategoryId);
                var existProduct = context.Products.Any(x => x.Id == item.ProductId);
                if (!existCategory || !existProduct)
                {
                    continue;
                }

                categoryProducts.Add(item);
            }

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Count}";
        }
    }
}