using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace F18I4DABH3Gr25.Models
{
    public class F18I4DABH3Gr25Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public F18I4DABH3Gr25Context() : base("name=Handin3-2")
        {
        }

        public System.Data.Entity.DbSet<HandIn2._1.Address> Addresses { get; set; }

        public System.Data.Entity.DbSet<HandIn2._1.Email> Emails { get; set; }

        public System.Data.Entity.DbSet<HandIn2._1.Name> Names { get; set; }

        public System.Data.Entity.DbSet<HandIn2._1.Person> People { get; set; }

        public System.Data.Entity.DbSet<HandIn2._1.Phone> Phones { get; set; }

        public System.Data.Entity.DbSet<HandIn2._1.xType> xTypes { get; set; }
    }
}
