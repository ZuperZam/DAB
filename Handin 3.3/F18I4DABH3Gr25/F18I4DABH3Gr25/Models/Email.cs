using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DokumentDB
{
    public class Email //Contains information of phone number, phone company and phone usage
    {
        public int EmailID { get; set; }

        public string _email;

        public string Emails
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
