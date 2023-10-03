using ProvaPub.Models;
using ProvaPub.Services.Abstract;
using ProvaPub.Strategy.Concrete;

namespace ProvaPub.Services.Concrete
{
    public class OrderService : IOrderService
    {
        public async Task<Order> PayOrder(string paymentMethod, decimal paymentValue, int customerId)
        {
            Operation.Initial(paymentMethod, paymentValue);

            //if (paymentMethod == "pix")
            //{
            //    //Faz pagamento...
            //}
            //else if (paymentMethod == "creditcard")
            //{
            //    //Faz pagamento...
            //}
            //else if (paymentMethod == "paypal")
            //{
            //    //Faz pagamento...
            //}

            return await Task.FromResult(new Order()
            {
                Value = paymentValue,
                OrderDate = DateTime.Now,
                CustomerId = customerId
            });
        }
    }
}
