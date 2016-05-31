using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    //Facade pattern for airline services 

    class AirlineServices
    {
        private Staff staff;
        private Customer customer;
        private Ticket ticket;
        public AirlineServices()
        {
            staff = new Staff();
            customer = new Customer();
        }
        //Login to system
        public void login(){

        }
        //add customer
        public void addCustomer()
        {

        }
        //book ticket
        public void bookTicket()
        {

        }
        //refund ticket
        public void refundTicket()
        {

        }

    }
}
