using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  FlightTicket class
    /// </summary>
    class FlightTicket
    {
        private double cost;
        private DateTime date;
        private Flight flight;
        private Aircraft aircraft;
        private Ticket ticket;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public Flight Flight
        {
            get { return flight; }
            set { flight = value; }
        }

        public Aircraft Aircraft
        {
            get { return aircraft; }
            set { aircraft = value; }
        }
         
          public Ticket Ticket
        {
            get { return ticket; }
            set { ticket = value; }
        }
         

        public FlightTicket Search()
        {
            return this;
        }

        public void ViewSchedule(Flight flight)
        {

        }

        public void ViewHistoryOfFlight(Flight flight)
        {

        }
    }
}
