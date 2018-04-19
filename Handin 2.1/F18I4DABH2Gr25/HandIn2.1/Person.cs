using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    public class Person //Creates a person along with all the information that defines them
    {
        [Key]
        public int PersonID { get; set; }

        public Name Name { get; set; } = new Name();
        public ContactInformation ContactInformation { get; set; } = new ContactInformation();
        public Type Type { get; set; } = new Type();
        public Addresses Addresses { get; set; } = new Addresses();
        public Address Address { get; set; } = new Address();

        public Person()
        {
            using (var db = new PersonContext())
            {
                Console.WriteLine("Enter your first name: ");
                Name.FirstName = Console.ReadLine();
                Console.WriteLine("Enter your middle name: ");
                Name.MiddleName = Console.ReadLine();
                Console.WriteLine("Enter your last name: ");
                Name.LastName = Console.ReadLine();
                db.Name.Add(Name);

                Console.WriteLine("\nEnter your email: ");
                ContactInformation.AddEmail(Console.ReadLine());
                Console.WriteLine("Enter your phone number, phone company and phone usage: ");
                ContactInformation.AddPhoneNumber(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                db.ContactInformation.Add(ContactInformation);

                Console.WriteLine("\nEnter your age: ");
                Type.Age = Console.ReadLine();
                Console.WriteLine("Enter your sex: ");
                Type.Sex = Console.ReadLine();
                db.Type.Add(Type);

                Console.WriteLine("\nEnter your street name: ");
                Address.StreetName = Console.ReadLine();
                Console.WriteLine("Enter your house number: ");
                Address.HouseNumber = Console.ReadLine();
                Console.WriteLine("Enter your zipcode: ");
                Address.ZipCode = Console.ReadLine();
                Console.WriteLine("Enter your city's name: ");
                Address.CityName = Console.ReadLine();
                db.Address.Add(Address);

                Addresses.AddAddress(Address);
                db.Addresses.Add(Addresses);
                db.SaveChanges();
            }
        }
    }
}