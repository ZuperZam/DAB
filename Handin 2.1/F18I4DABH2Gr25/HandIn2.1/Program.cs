using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonContext())
            {
                //Person person = new Person();
                //db.Person.Add(person);
                //db.SaveChanges();

                //var query = from b in db.Person
                //            orderby b.PersonID
                //            select b;

                foreach (var item in db.ContactInformation)
                {
                    Console.WriteLine(item._email[0]);
                    //var i = item.ContactInformation._email.Count;
                    //for (var x = 0; x < i; x++)
                    //{
                    //    Console.WriteLine(item.ContactInformation._email[x]);
                    //}
                }
            }
        }
    }
}