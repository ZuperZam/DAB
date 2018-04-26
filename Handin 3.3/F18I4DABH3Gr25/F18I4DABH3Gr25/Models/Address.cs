using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentDB
{
    public class Address //Generic address with all the necessary information
    {
        public int AddressID { get; set; }
        public string _streetname;
        public string _housenumber;
        public string _zipcode;
        public string _cityname;
        public virtual List<Person> Person { get; set; }

        public string StreetName
        {
            get { return _streetname; }
            set { _streetname = value; }
        }

        public string HouseNumber
        {
            get { return _housenumber; }
            set { _housenumber = value; }
        }

        public string ZipCode
        {
            get { return _zipcode; }
            set { _zipcode = value; }
        }

        public string CityName
        {
            get { return _cityname; }
            set { _cityname = value; }
        }
    }

}
