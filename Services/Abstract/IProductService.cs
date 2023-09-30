using ProvaPub.Models;

namespace ProvaPub.Services.Abstract
{
    public interface IProductService
    {
        ProductList ListProducts(int page);
    }
}
