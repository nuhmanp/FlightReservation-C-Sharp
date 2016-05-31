using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Route class
    /// </summary>
    class Route
    {
        private Airport fromAir;
        private Airport toAir;

        internal Airport FromAir
        {
            get { return fromAir; }
            set { fromAir = value; }
        }        

        internal Airport ToAir
        {
            get { return toAir; }
            set { toAir = value; }
        }
    }
}
