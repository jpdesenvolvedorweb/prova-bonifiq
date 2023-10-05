using ProvaPub.Models;

namespace ProvaPub.Services.Abstract
{
    public interface ICustomerService
    {
        GenericList<Customer> ListCustomers(int page);
        Task<bool> CanPurchase(int customerId, decimal purchaseValue);

    }
}
