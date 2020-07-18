using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTO;
using ProductShop.Models;

namespace ProductShop
{
    public class StartUp
    {
        private const string DefaultPath = "../../../Datasets";

        public static void Main()
        {
            var db = new ProductShopContext();

            var result = GetUsersWithProducts(db);
            File.WriteAllText(DefaultPath + "/Results/users-and-products.json", result);
            
            //EnsureCreatedDatabase(db);
        }

        private static void EnsureCreatedDatabase(ProductShopContext db)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
        }

        //01.ImportUsers
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            var settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

            User[] users = JsonConvert.DeserializeObject<User[]>(inputJson, settings);

            context.AddRange(users);
            context.SaveChanges();
            
            return $"Successfully imported {users.Length}";
        }

        //02.ImportProducts
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            var setting = new JsonSerializerSettings { Formatting = Formatting.Indented };

            Product[] products = JsonConvert.DeserializeObject<Product[]>(inputJson, setting);

            context.Products.AddRange(products);
            context.SaveChanges();

            return $"Successfully imported {products.Length}";
        }

        //03.ImportCategories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            var settings = new JsonSerializerSettings 
            { 
                Formatting = Formatting.Indented, 
            };

            Category[] categories = JsonConvert.
                    DeserializeObject<Category[]>(inputJson, settings)
                            .Where(c => c.Name != null)
                            .ToArray();

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return $"Successfully imported {categories.Length}";
        }

        //04.Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            var settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

            CategoryProduct[] categoryProducts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson, settings);

            context.CategoryProducts.AddRange(categoryProducts);
            context.SaveChanges();

            return $"Successfully imported {categoryProducts.Length}";
        }

        //05. Export Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var rangeProducts = context.Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ProductDTO()
                {
                    ProductName = p.Name,
                    Price = p.Price,
                    Seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(p => p.Price)
                .ToList();

            var setting = new JsonSerializerSettings { Formatting = Formatting.Indented };

            var result = JsonConvert.SerializeObject(rangeProducts, setting);

            return result;
        }

        //06.Get Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var usersSolidProducts = context.Users
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new UserSoldProductDTO
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SolidProducts = u.ProductsSold.Where(p => p.Buyer != null)
                    .Select(p => new SolidProductDTO
                    {
                        Name = p.Name,
                        Price = p.Price,
                        BuyerFirstName = p.Buyer.FirstName,
                        BuyerLastName = p.Buyer.LastName
                    }).ToArray()
                });

            var setting = new JsonSerializerSettings { Formatting = Formatting.Indented };

            var json = JsonConvert.SerializeObject(usersSolidProducts, setting);

            return json;
        }

        //07. Export Categories By Products Count 
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var categories = context.Categories
                .Select(c => new CategoryProductDTO
                {
                    Name = c.Name,
                    ProductsCount = c.CategoryProducts.Count(),
                    AveragePrice = c.CategoryProducts.Average(cp => cp.Product.Price).ToString("F2"),
                    TotalRevenue = c.CategoryProducts.Sum(cp => cp.Product.Price).ToString("F2")
                })
                .OrderByDescending(c => c.ProductsCount)
                .ToArray();

            var settings = new JsonSerializerSettings 
            { 
                Formatting = Formatting.Indented 
            };

            var json = JsonConvert.SerializeObject(categories, settings);
            return json;
        }

        //08.Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Any(p => p.Buyer != null))
                .OrderByDescending(u => u.ProductsSold.Count(ps => ps.Buyer != null))
                .Select(u => new
                {
                    lastName = u.LastName,
                    age = u.Age,
                    solidProducts = new
                    {
                        count = u.ProductsSold.Count(ps => ps.Buyer != null),
                        products = u.ProductsSold.Where(ps => ps.Buyer != null)
                                        .Select(p => new
                                        {
                                            name = p.Name,
                                            price = p.Price
                                        })
                                        .ToArray()
                    }
                })
                .OrderByDescending(u => u.solidProducts.count)
                .ToList();


            var userSolidProducts = new
            {
                usersCount = users.Count,
                users = users
            };

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            var json = JsonConvert.SerializeObject(userSolidProducts, settings);
            return json;
        }
    }
}