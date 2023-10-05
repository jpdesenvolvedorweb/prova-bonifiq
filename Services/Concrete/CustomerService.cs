using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using ProvaPub.Models;
using ProvaPub.Pagination;
using ProvaPub.Repository;
using ProvaPub.Services.Abstract;

namespace ProvaPub.Services.Concrete
{
    public class CustomerService : ICustomerService
    {
        readonly TestDbContext _ctx;

        public CustomerService(TestDbContext ctx)
        {
            _ctx = ctx;
        }

        public GenericList<Customer> ListCustomers(int page)
        {
            var total = _ctx.Customers.Count();
            var numberOfPages = 10;

            return new GenericList<Customer>() 
            { 
                HasNext = QuantityPagination.VerificarHasNext(page, numberOfPages, total), 
                TotalCount = 10, 
                Elements = _ctx.Customers.Skip((page - 1) * numberOfPages)
                                          .Take(numberOfPages).ToList()
            };
        }

        public async Task<bool> CanPurchase(int customerId, decimal purchaseValue)
        {
            if (customerId <= 0) throw new ArgumentOutOfRangeException(nameof(customerId));

            if (purchaseValue <= 0) throw new ArgumentOutOfRangeException(nameof(purchaseValue));

            //Business Rule: Non registered Customers cannot purchase
            var customer = await _ctx.Customers.FindAsync(customerId);
            if (customer == null) throw new InvalidOperationException($"Customer Id {customerId} does not exists");

            //Business Rule: A customer can purchase only a single time per month
            var baseDate = DateTime.UtcNow.AddMonths(-1);
            var ordersInThisMonth = await _ctx.Orders.CountAsync(s => s.CustomerId == customerId && s.OrderDate >= baseDate);
            if (ordersInThisMonth > 0)
                return false;

            //Business Rule: A customer that never bought before can make a first purchase of maximum 100,00
            var haveBoughtBefore = await _ctx.Customers.CountAsync(s => s.Id == customerId && s.Orders.Any());
            if (haveBoughtBefore == 0 && purchaseValue > 100)
                return false;

            return true;
        }

    }
}
