using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Address //Generic address with all the necessary information
    {
        [Key]
        public int AddressID { get; set; }
        private string _streetname;
        private string _housenumber;
        private string _zipcode;
        private string _cityname;
        public List<Person> Person { get; set; }

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
