using Abstract_Interface.Abstract;
using Abstract_Interface.Abstract.Payment;
using Abstract_Interface.Abstract.Transportation;

namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract
            //PaymentServices stripePayment = new StripePayment(100.0, "Visa", "token123");

            //stripePayment.Pay();

            TransportationServices standardTransportation = new StandardTransportation("T123", "C45", "2023-10-15", "USER123dasdasdadadassd");

            standardTransportation.Book();
            #endregion

        }
    }
}
