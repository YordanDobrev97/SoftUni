using Musaca.Data;
using Musaca.Models;
using Musaca.ViewModels.Products;
using System.Collections.Generic;
using System.Linq;

namespace Musaca.Services
{
    public class ProductsService : IProductsService
    {
        private readonly ApplicationDbContext db;

        public ProductsService(ApplicationDbContext db)
        {
            this.db = db;
        }

        public List<ProductViewModel> All()
        {
            var products = this.db.Products
                .Select(e => new ProductViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Barcode = e.Barcode,
                Picture = e.Picture,
                Price = e.Price
            }).ToList();

            return products;
        }

        public void Create(ProductViewModel input)
        {
            this.db.Products.Add(new Product
            {
                Name = input.Name,
                Barcode = input.Barcode,
                Picture = input.Picture,
                Price = input.Price
            });

            this.db.SaveChanges();
        }

        public void Delete(string productId)
        {
            var product = this.db.Products.Where(x => x.Id == productId)
                .FirstOrDefault();

            this.db.Products.Remove(product);
            this.db.SaveChanges();
        }

        public DetailsProductViewModel Details(string productId)
        {
            var product = this.db.Products
                .Where(x => x.Id == productId)
                .Select(e => new DetailsProductViewModel
                {
                    Id = e.Id,
                    Name = e.Name,
                    Picture = e.Picture,
                    Price = e.Price
                }).FirstOrDefault();

            return product;
        }
    }
}
