using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Ticket class
    /// </summary>
    class Ticket
    {
        private int passangerNumber;
        private double fare;
        private bool roundTrip;
        private Customer customer;
        private SeatAssociation seat;
        private TicketType type;
        public int PassengerNumber
        {
            get { return passangerNumber; }
            set { passangerNumber = value; }
        }

        public double Fare
        {
            get { return fare; }
            set { fare = value; }
        }

        public bool RoundTrip
        {
            get { return roundTrip; }
            set { roundTrip = value; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }
        public SeatAssociation Seat
        {
            get { return seat; }
            set { seat = value; }
        }

         public TicketType Type
        {
            get { return type; }
            set { type = value; }
        }
         

        public void SearchTicket(string ticketNumber)
        {

        }
        public void ViewTicket()
        {

        }
        public void Reserve()
        {

        }
        public void Purchase()
        {

        }
    }
}
