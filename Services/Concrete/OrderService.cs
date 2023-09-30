using ProvaPub.Models;
using ProvaPub.Services.Abstract;

namespace ProvaPub.Services.Concrete
{
    public class OrderService : IOrderService
    {
        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            if (paymentMethod == "pix")
            {
                //Faz pagamento...
            }
            else if (paymentMethod == "creditcard")
            {
                //Faz pagamento...
            }
            else if (paymentMethod == "paypal")
            {
                //Faz pagamento...
            }

            return await Task.FromResult(new Order()
            {
                Value = paymentValue,
                OrderDate = DateTime.Now,
                CustomerId = customerId
            });
        }
    }
}
