using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Flight class
    /// </summary>
    class Flight
    {
        private string number;
        private DateTime arrivalTime;
        private DateTime departTime;
        // private Route route;

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public DateTime ArrivalTime
        {
            get { return arrivalTime; }
            set { arrivalTime = value; }
        }
        public DateTime DepartTime
        {
            get { return departTime; }
            set { departTime = value; }
        }
        /*
        public Route Route
        {
            get { return route; }
            set { route = value; }
        }*/

        public Flight()
        {

        }
        public Flight View()
        {
            return this;
        }
        public void Update(Flight flight)
        {

        }
        public void Delete(Account flight)
        {

        }
        public TimeSpan Duration(DateTime arrivalTime, DateTime departTime)
        {
            return departTime - arrivalTime;
        }
    }
}
