using Abstract_Interface.Abstract;
using Abstract_Interface.Abstract.Payment;
using Abstract_Interface.Abstract.Transportation;
using Abstract_Interface.Interface;

namespace Abstract_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Abstract
            //PaymentServices stripePayment = new StripePayment(100.0, "Visa", "token123");

            //stripePayment.Pay();

            //StandardTransportation standardTransportation = new StandardTransportation("T123", "C45", "2023-10-15", "USER123dasdasdadadassd");

            //standardTransportation.Book();
            #endregion

            #region Interface
            IBank bank = new CreditCard(1000);

            // bank.Deposit();

            MasterCard masterCard = new MasterCard(500);

            //   masterCard.Withdraw();

            Console.WriteLine($"Credit Card Amount: {masterCard.Amount}");

            #endregion
        }
    }
}
