using Musaca.Services;
using Musaca.ViewModels.Products;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Musaca.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public HttpResponse All()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var products = this.productsService.All();
            return this.View(products);
        }

        public HttpResponse Create()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Create(ProductViewModel input)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            if (string.IsNullOrEmpty(input.Name)
                || input.Name.Length < 5
                || input.Name.Length > 20)
            {
                return this.Error("Invalid product name.");
            }

            if (input.Price < 0)
            {
                return this.Error("The price should be positive value.");
            }

            if (input.Barcode.ToString().Length != 12)
            {
                this.Error("Invalid barcode");
            }

            this.productsService.Create(input);
            return this.Redirect("/Products/All");
        }

        public HttpResponse Details(string productId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var product = this.productsService.Details(productId);
            return this.View(product);
        }

        public HttpResponse Delete(string productId)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.productsService.Delete(productId);
            return this.Redirect("/Products/All");
        }
    }
}
