using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Phone //Contains information of phone number, phone company and phone usage
    {
        [Key]
        public int PhoneID { get; set; }

        private string _phoneNumber;
        private string _phoneCarrier;
        private string _phoneUsage;
        public List<Person> Person { get; set; }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string PhoneCarrier
        {
            get { return _phoneCarrier; }
            set { _phoneCarrier = value; }
        }

        public string PhoneUsage
        {
            get { return _phoneUsage; }
            set { _phoneUsage = value; }
        }
    }
}
