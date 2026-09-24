using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Payment
{
    internal abstract class PaymentServices
    {
        protected PaymentServices(double amount, string cardType, string token)
        {
            Amount = amount;
            CardType = cardType;
            Token = token;
        }

        public double Amount { get; private set; }

        public string CardType { get; private set; }

        public string Token { get; private set; }

        public abstract bool Pay();

        public override string ToString()
        {
            return $"Amount: {Amount}, CardType: {CardType}, Token: {Token}";
        }
    }
}
    