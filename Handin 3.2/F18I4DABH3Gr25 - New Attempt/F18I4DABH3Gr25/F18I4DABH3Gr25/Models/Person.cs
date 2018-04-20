﻿using System;
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
        public List<Phone> PhoneNumbers { get; set; } = new List<Phone>();
        public xType Type { get; set; } = new xType();
        public Address MainAddress { get; set; } = new Address();
        public List<Address> AlternateAddresses { get; set; } = new List<Address>();
        public List<Email> Emails { get; set; } = new List<Email>();
    }
}