using ProvaPub.Strategy.Abstract;

namespace ProvaPub.Strategy.Concrete
{
    public class Pix : ITypePayments
    {
        public void Payment(decimal paymentValue)
        {
            //Operação de pagamento;
        }
    }
}
