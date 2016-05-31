using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservation
{
    /// <summary>
    ///  Aircraft class
    /// </summary>
    class Aircraft
    {
        private int id;
        private string year;
        private Brand brand;
        private string manufacture;
        private string model;
        public Aircraft(int id, string year, Brand brand, string manufacture, string model)
        {
            this.id = id;
            this.year = year;
            this.brand = brand;
            this.manufacture = manufacture;
            this.model = model;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        internal Brand Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        
        public string Manufacture
        {
            get { return manufacture; }
            set { manufacture = value; }
        }
        
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        
        public string Year
        {
            get { return year; }
            set { year = value; }
        }
    }
}
