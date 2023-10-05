using ProvaPub.Strategy.Abstract;

namespace ProvaPub.Strategy.Concrete
{
    public class Paypal : ITypePayments
    {
        public void Payment(decimal paymentValue)
        {
            //Operação de pagamento;
        }
    }
}
