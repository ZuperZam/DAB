using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DokumentDB
{
    public class Person : Microsoft.Azure.Documents.Resource //Creates a person along with all the information that defines them
    {
        public string Id { get; set; }

        public virtual Name Name { get; set; } = new Name();
        public virtual List<Phone> PhoneNumbers { get; set; } = new List<Phone>();
        public virtual Address MainAddress { get; set; } = new Address();
        public virtual List<Address> AlternateAddresses { get; set; } = new List<Address>();
        public virtual List<Email> Emails { get; set; } = new List<Email>();

    }
}