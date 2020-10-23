using Musaca.ViewModels.Products;
using System.Collections.Generic;

namespace Musaca.Services
{
    public interface IProductsService
    {
        void Create(ProductViewModel input);

        List<ProductViewModel> All();

        DetailsProductViewModel Details(string productId);

        void Delete(string productId);
    }
}
