using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface
{
    internal class CreditCard : IBank
    {
        public CreditCard(int amount)
        {
            Amount = amount;
        }

        public int Amount { get; set; }

        public void Deposit()
        {
            throw new NotImplementedException();
        }

        public void Withdraw()
        {
            throw new NotImplementedException();
        }
    }
}
