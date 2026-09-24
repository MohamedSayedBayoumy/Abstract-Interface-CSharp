using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Transportation
{
    internal class StandardTransportation : TransportationServices
    {
        public StandardTransportation(string ticketNumber, string chairNumber, string date, string userId)
            : base(ticketNumber, chairNumber, date, userId)
        {
        }

        public override bool Book()
        {
            if (this.CheckUserFromGoverment())
            {
                Console.WriteLine($"Booking confirmed for standard transportation : {this.ToString()}");

                return true;
            }
            else
            {
                Console.WriteLine("Booking rejected.");
                return false;
            }
        }
    }
}
