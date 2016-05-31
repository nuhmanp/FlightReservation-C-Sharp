using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Seat class
    /// </summary>
    class Seat
    {
        private int id;
        private int number;
        private int row;
        private bool availability;
        private string location;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public bool Availability
        {
            get { return availability; }
            set { availability = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public Seat()
        {

        }
        public Seat View()
        {
            return this;
        }

        public void Update(Seat seat)
        {

        }

        public void Delete(Seat seat)
        {

        }
    }
}
