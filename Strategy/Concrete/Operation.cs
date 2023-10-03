namespace ProvaPub.Strategy.Concrete
{
    public static class Operation
    {
        public static void Initial(string paymentMethod, decimal paymentValue)
        {
            switch (paymentMethod)
            {
                case "pix" :
                    var addPaymets = new AddPayment(new Pix());
                    addPaymets.ExecutePayment(paymentValue);
                    break;
                case "creditcard" :
                    addPaymets = new AddPayment(new Card());
                    addPaymets.ExecutePayment(paymentValue);
                    break ;
                case "paypal" :
                    addPaymets = new AddPayment(new Paypal());
                    addPaymets.ExecutePayment(paymentValue);
                    break;
                default :
                    break;
            }
        }
    }
}
