using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HandIn2._1
{
    public class PersonContexts : DbContext
    {
        public PersonContexts() : base("name=HandIn2-2-Gr25")  { }

        public DbSet<Person> Person { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Name> Name { get; set; }
        public DbSet<Type> Type { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<Email> Email { get; set; }
    }
}
