using AutoMapper;
using ProductShop.Data;
using ProductShop.Dtos.Export;
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

            var result = GetCategoriesByProductsCount(db);
            File.WriteAllText(Path + "/Results/categories-by-products.xml", result);
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

        //05.
        public static string GetProductsInRange(ProductShopContext context)
        {
            var products = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ExportProductDTO
                {
                    Name = p.Name,
                    Price = p.Price,
                    Buyer = $"{p.Buyer.FirstName} {p.Buyer.LastName}"
                })
                .OrderBy(p => p.Price)
                .Take(10)
                .ToArray();

            var root = "Products";
            var xmlProducts = XmlConverter.Serialize(products, root);
            return xmlProducts;
        }

        //06.
        public static string GetSoldProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any())
                .Select(u => new ExportUserSoldProductDTO
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold.Select(ps => new SoldProductDTO
                    {
                        Name = ps.Name,
                        Price = ps.Price
                    })
                    .ToArray()
                })
                .OrderBy(l => l.LastName)
                .ThenBy(f => f.FirstName)
                .Take(5)
                .ToArray();

            var root = "Users";
            var xml = XmlConverter.Serialize(users, root);
            return xml;
        }

        //07.
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new CategoryProductDTO
                {
                    Name = c.Name,
                    Count = c.CategoryProducts.Count,
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price),
                    TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price)
                })
                .OrderByDescending(p => p.Count)
                .ThenBy(p => p.TotalRevenue)
                .ToArray();

            var root = "Categories";
            var xml = XmlConverter.Serialize(categories, root);
            return xml;
        }
    }
}