using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new PersonContexts())
            {
                Person Person = new Person();
                Console.WriteLine("Enter your first name: ");
                Person.Name.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your middle name: ");
                Person.Name.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                Person.Name.LastName = Console.ReadLine();
                db.Name.Add(Person.Name);

                Console.WriteLine("\nEnter your email: ");
                Email TempEmail = new Email();
                TempEmail.Emails = Console.ReadLine();
                Person.Emails.Add(TempEmail);
                db.Email.Add(TempEmail);

                Console.WriteLine("Enter your phone number, phone carrier and phone usage: ");
                Phone TempPhone = new Phone();
                TempPhone.PhoneNumber = Console.ReadLine();
                TempPhone.PhoneCarrier = Console.ReadLine();
                TempPhone.PhoneUsage = Console.ReadLine();
                Person.PhoneNumbers.Add(TempPhone);
                db.Phone.Add(TempPhone);

                Console.WriteLine("\nEnter your age: ");
                Person.Type.Age = Console.ReadLine();
                Console.WriteLine("Enter your sex: ");
                Person.Type.Sex = Console.ReadLine();
                db.Type.Add(Person.Type);

                Console.WriteLine("\nEnter your street name: ");
                Person.MainAddress.StreetName = Console.ReadLine();
                Console.WriteLine("Enter your house number: ");
                Person.MainAddress.HouseNumber = Console.ReadLine();
                Console.WriteLine("Enter your zipcode: ");
                Person.MainAddress.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your city's name: ");
                Person.MainAddress.CityName = Console.ReadLine();
                db.Addresses.Add(Person.MainAddress);

                Console.WriteLine("\nEnter your secondary street name: ");
                Address TempAddress = new Address();
                TempAddress.StreetName = Console.ReadLine();
                Console.WriteLine("Enter your secondary house number: ");
                TempAddress.HouseNumber = Console.ReadLine();
                Console.WriteLine("Enter your secondary zipcode: ");
                TempAddress.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your secondary city's name: ");
                TempAddress.CityName = Console.ReadLine();
                Person.AlternateAddresses.Add(TempAddress);
                db.Addresses.Add(TempAddress);

                db.Person.Add(Person);
                db.SaveChanges();
            }
        }
    }
}
