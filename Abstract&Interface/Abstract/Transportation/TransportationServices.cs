using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Interface.Abstract.Transportation
{
    internal abstract class TransportationServices
    {
        protected TransportationServices(string ticketNumber, string chairNumber, string date, string userId)
        {
            TicketNumber = ticketNumber;
            ChairNumber = chairNumber;
            Date = date;
            UserId = userId;
        }

        public string TicketNumber { get; private set; }
        public string ChairNumber { get; private set; }
        public string Date { get; private set; }
        public string UserId { get; private set; }

        public abstract bool Book();

        public bool CheckUserFromGoverment()
        {
            if (UserId is null)
            {
                return false; 
            }
            Console.WriteLine("Checking user from government database...");
            var isUserValid = UserId.Length > 10 ? true : false; // Simulating a check against a government database
            return isUserValid;
        }

        public override string ToString()
        {
            return $"TicketNumber: {TicketNumber}, ChairNumber: {ChairNumber}, Date: {Date}, UserId: {UserId}";
        }
    }
}
