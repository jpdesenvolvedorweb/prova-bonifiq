using ProvaPub.Models;
using ProvaPub.Pagination;
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

        public GenericList<Product> ListProducts(int page)
        {
            var total = _ctx.Products.Count();
            var numberOfPages = 10;
            return new GenericList<Product>()
            {
                HasNext = QuantityPagination.VerificarHasNext(page, numberOfPages, total),
                TotalCount = 10,
                Elements = _ctx.Products.Skip((page - 1) * numberOfPages)
                                          .Take(numberOfPages).ToList()
            };
        }
    }
}
