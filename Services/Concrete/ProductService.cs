using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services.Abstract;

namespace ProvaPub.Services.Concrete
{
    public class ProductService : IProductService
    {
        TestDbContext _ctx;

        public ProductService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public ProductList ListProducts(int page)
        {
            return new ProductList() { HasNext = false, TotalCount = 10, Products = _ctx.Products.ToList() };
        }

    }
}
