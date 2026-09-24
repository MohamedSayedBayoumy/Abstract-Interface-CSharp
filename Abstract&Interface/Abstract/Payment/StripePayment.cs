using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Payment
{
    internal class StripePayment : PaymentServices
    {
        public StripePayment(double amount, string cardType, string token)
            : base(amount, cardType, token)
        {
        }

        public override bool Pay()
        {
            Console.WriteLine("Processing Stripe payment...");
            Console.WriteLine($"Stripe Payment Done with token {Token}");
            Console.WriteLine($"Stripe Payment Done with token {this.ToString()}");

            return true;
        }


    }
}
