using ProvaPub.Strategy.Abstract;

namespace ProvaPub.Strategy.Concrete
{
    public class Card : ITypePayments
    {
        public void Payment(decimal paymentValue)
        {
            //Operação de pagamento;
        }
    }
}
