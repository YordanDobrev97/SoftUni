using Andreys.Services;
using Andreys.ViewModels;
using SUS.HTTP;
using SUS.MvcFramework;

namespace Andreys.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        public HttpResponse Add()
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            return this.View();
        }

        [HttpPost]
        public HttpResponse Add(AddProductInputModel input)
        {
            if (string.IsNullOrWhiteSpace(input.Name) || input.Name.Length < 4
                || input.Name.Length > 20)
            {
                return this.Error("Invalid product name");
            }

            if (input?.Description.Length > 10)
            {
                return this.Error("Invalid description.");
            }

            this.productsService.Add(input);

            return this.Redirect("/Home/Home");
        }

        public HttpResponse Details(int id)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            var product = this.productsService.Details(id);
            return this.View(product);
        }

        public HttpResponse Delete(int id)
        {
            if (!this.IsUserSignedIn())
            {
                return this.Redirect("/Users/Login");
            }

            this.productsService.Delete(id);
            return this.Redirect("/Home/Home");
        }
    }
}
