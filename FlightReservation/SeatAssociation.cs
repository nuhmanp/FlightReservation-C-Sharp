using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Seat Association comprises FlightTicket, Aircraft and seat
    /// </summary>
    class SeatAssociation
    {
        private int id;
        private FlightTicket flight;
        private Aircraft aircraft;
        private Seat seat;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public FlightTicket Flight
        {
            get { return flight; }
            set { flight = value; }
        }
    }
}
