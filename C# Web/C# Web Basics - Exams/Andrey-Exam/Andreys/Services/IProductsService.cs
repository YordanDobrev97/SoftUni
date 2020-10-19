using Andreys.ViewModels;
using System.Collections.Generic;

namespace Andreys.Services
{
    public interface IProductsService
    {
        void Add(AddProductInputModel input);

        List<ProductsViewModel> All();

        DetailsProductViewModel Details(int id);

        void Delete(int id);
    }
}
