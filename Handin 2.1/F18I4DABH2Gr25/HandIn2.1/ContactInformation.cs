using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class ContactInformation //Contains information of email, phone number, phone company and phone usage
    {
        [Key]
        public int ContactInformationID { get; set; }

        public List<string> _email { get; set; } = new List<string>();
        private TupleList<string, string, string> _phonenumber = new TupleList<string, string, string>();

        public void AddPhoneNumber(string phonenumber, string company, string phoneusage)
        {
            _phonenumber.Add(phonenumber, company, phoneusage);
        }

        public void RemovePhoneNumber(string phonenumber)
        {
            _phonenumber.Remove(phonenumber, "" , "");
        }

        public void AddEmail(string email)
        {
            _email.Add(email);
        }

        public void RemoveEmail(string email)
        {
            _email.Remove(email);
        }
    }

    public class TupleList<T1, T2, T3> : List<Tuple<T1, T2, T3>> //Inherits add and remove from list and adjusts them to work with Tuples
    {
        public void Add(T1 item, T2 item2, T3 item3)
        {
            Add(new Tuple<T1, T2, T3>(item,item2,item3));
        }

        public void Remove(T1 item, T2 item2, T3 item3)
        {
            Remove(new Tuple<T1, T2, T3>(item, item2, item3));
        }
    }
}
