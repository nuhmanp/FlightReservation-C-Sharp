using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Account class
    /// </summary>
    class Account
    {
        private string firstName;
        private string lastName;
        private string password;
        private string email;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Account()
        {

        }
        public Account ViewAccount()
        {
            return this;
        }
        public void UpdateAccount(Account account)
        {

        }
        public void DeleteAccount(Account account)
        {

        }
    }
}
