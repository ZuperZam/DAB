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

    public class Addresses //Contains a list of addresses, along with an index to define the primary address
    {
        [Key]
        public int AddressesID { get; set; }

        public List<Address> _addresses { get; set; } = new List<Address>();
        private int _primaryaddress = 0;

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public void RemoveAddress(Address address)
        {
            _addresses.Remove(address);
        }

        public void SetPrimaryAddress(Address address)
        {
            var temp = FindAddressInArray(address);
            if (FindAddressInArray(address) > -1)
            {
                _primaryaddress = temp;
            }
            else
            {
                Console.WriteLine("Error! The address you have entered is not assigned to you");
            }
        }

        public Address GetPrimaryAddress()
        {
            return _addresses[_primaryaddress];
        }

        private int FindAddressInArray(Address address) //Looks for a specific address in the list and returns the index to said address
        {
            if (_addresses.Contains(address))
                return _addresses.IndexOf(address);
            else
                return -1;
        }

    }
}
