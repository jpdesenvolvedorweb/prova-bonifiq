using ProvaPub.Models;

namespace ProvaPub.Services.Abstract
{
    public interface IOrderService
    {
        Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId);
    }
}
