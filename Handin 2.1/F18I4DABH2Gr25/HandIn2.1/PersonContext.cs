using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HandIn2._1
{
    public class PersonContext : DbContext
    {
        public DbSet<Person> Person { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Name> Name { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<ContactInformation> ContactInformation { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
