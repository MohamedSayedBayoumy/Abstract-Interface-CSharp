using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Interface
{
    internal interface IBank
    {
        public  int Amount { get;  set; }
        public void Deposit();
        public void Withdraw();
    }
}
