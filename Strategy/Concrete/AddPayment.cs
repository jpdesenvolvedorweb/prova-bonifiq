using ProvaPub.Strategy.Abstract;

namespace ProvaPub.Strategy.Concrete
{
    public class AddPayment
    {
        private ITypePayments _typePayments;
        public AddPayment(ITypePayments typePayments)
        {
            _typePayments = typePayments;       
        }

        public void ExecutePayment(decimal paymentValue)
        {
            _typePayments.Payment(paymentValue);
        }
    }
}
