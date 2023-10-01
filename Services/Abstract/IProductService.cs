using ProvaPub.Models;

namespace ProvaPub.Services.Abstract
{
    public interface IProductService
    {
        GenericList<Product> ListProducts(int page);
    }
}
