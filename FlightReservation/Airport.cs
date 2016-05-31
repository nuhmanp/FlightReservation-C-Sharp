using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Airport class
    /// </summary>
    class Airport
    {
        private string code;
        private string location;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        

        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public void addAirport(string code, string location)
        {
            this.code = code;
            this.location = location;
        }

    }
}
