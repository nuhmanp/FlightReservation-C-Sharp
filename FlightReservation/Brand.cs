﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Brand class
    /// </summary>
    class Brand
    {
        private int id;
        private string name;
        public Brand(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
