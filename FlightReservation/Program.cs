using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    /// <summary>
    ///  Facade Design pattern for whole system
    /// </summary>
    class AirlineSystem
    {
        private AirlineSys aSys;
        private AirlineServices aService;

        public AirlineSystem()
        {
            aSys = new AirlineSys();
            aService = new AirlineServices();
        }

        public void service()
        {
            Console.WriteLine("\nAirline services ---- ");
            aService.login();
            aService.addCustomer();
            aService.bookTicket();
            aService.refundTicket();

            
        }

        public void system()
        {
            Console.WriteLine("\nAirline system() ---- ");
            aSys.addAircraft();
            aSys.addAirport();
        }
    }

 

}
