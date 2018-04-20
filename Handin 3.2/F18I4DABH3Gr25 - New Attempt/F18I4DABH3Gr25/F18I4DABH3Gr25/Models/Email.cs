using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Email //Contains information of phone number, phone company and phone usage
    {
        [Key] public int EmailID { get; set; }

        private string _email;

        public string Emails
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
