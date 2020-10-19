using Andreys.Data;
using Andreys.Models;
using Andreys.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Andreys.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext db;

        public ProductsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public void Add(AddProductInputModel input)
        {
            this.db.Products.Add(new Product
            {
                Name = input.Name,
                Description = input.Description,
                ImageUrl = input.ImageUrl,
                Category = (Category)Enum.Parse(typeof(Category), input.Category),
                Gender = (Gender)Enum.Parse(typeof(Gender), input.Gender),
                Price = input.Price
            });

            this.db.SaveChanges();
        }

        public List<ProductsViewModel> All()
        {
            return this.db.Products.Select(e => new ProductsViewModel
            {
                Id = e.Id,
                Name = e.Name,
                ImageUrl = e.ImageUrl,
                Price = e.Price
            }).ToList();
        }

        public void Delete(int id)
        {
            var product = this.db.Products
                .Where(e => e.Id == id)
                .FirstOrDefault();

            this.db.Products.Remove(product);
            this.db.SaveChanges();
        }

        public DetailsProductViewModel Details(int id)
        {
            return this.db.Products.Where(x => x.Id == id)
                .Select(e => new DetailsProductViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    ImageUrl = e.ImageUrl,
                    Description = e.Description,
                    Gender = e.Gender.ToString(),
                    Price = e.Price
                }).FirstOrDefault();
        }
    }
}
