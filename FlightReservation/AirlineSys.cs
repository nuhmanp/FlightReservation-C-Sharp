using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{

    /// <summary>
    ///  Facade pattern for Airline system functions
    /// </summary>
    class AirlineSys
    {
        private Aircraft aircraft;
        private Flight flight;
        private Airport airport;
        private Route route;
        private Brand brand;
        public AirlineSys()
        {
            //aircraft = new Aircraft();
            flight = new Flight();
            airport = new Airport();
        }
        //Add Aircraft
        public void addAircraft(){
            brand = new Brand(2, "Air Canada");
            aircraft = new Aircraft(2, "1977", brand, "Boiioo", "jkjj");


        }
        //add airport
        public void addAirport()
        {
            airport.addAirport("COK","Kochi");


        }

    }
}
