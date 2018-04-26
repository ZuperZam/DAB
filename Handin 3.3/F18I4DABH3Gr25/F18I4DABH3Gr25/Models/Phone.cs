using System.Collections.Generic;

namespace DokumentDB
{
    public class Phone //Contains information of phone number, phone company and phone usage
    {
        public int PhoneID { get; set; }

        public string _phoneNumber;
        public string _phoneCarrier;
        public string _phoneUsage;
        public virtual List<Person> Person { get; set; }

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
