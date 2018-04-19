using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandIn2._1
{
    class UnitOfWork
    {
        private PersonContexts context = new PersonContexts();
        private GenericRepository<PersonContexts, Person> personRepository;
        private GenericRepository<PersonContexts, Name> nameRepository;
        private GenericRepository<PersonContexts, Address> addressRepository;
        private GenericRepository<PersonContexts, Email> emailRepository;
        private GenericRepository<PersonContexts, Phone> phoneRepository;
        private GenericRepository<PersonContexts, Type> typeRepository;


        public GenericRepository<PersonContexts, Person> PersonRepository
        {
            get
            {
                if (this.personRepository == null)
                {
                    this.personRepository = new GenericRepository<PersonContexts, Person>(context);
                }
                return personRepository;
            }
        }

        public GenericRepository<PersonContexts, Name> NameRepository
        {
            get
            {
                if (this.nameRepository == null)
                {
                    this.nameRepository = new GenericRepository<PersonContexts, Name>(context);
                }
                return nameRepository;
            }
        }

        public GenericRepository<PersonContexts, Address> AddressRepository
        {
            get
            {
                if (this.addressRepository == null)
                {
                    this.addressRepository = new GenericRepository<PersonContexts, Address>(context);
                }
                return addressRepository;
            }
        }

        public GenericRepository<PersonContexts, Email> EmailRepository
        {
            get
            {
                if (this.emailRepository == null)
                {
                    this.emailRepository = new GenericRepository<PersonContexts, Email>(context);
                }
                return emailRepository;
            }
        }

        public GenericRepository<PersonContexts, Phone> PhoneRepository
        {
            get
            {
                if (this.phoneRepository == null)
                {
                    this.phoneRepository = new GenericRepository<PersonContexts, Phone>(context);
                }
                return phoneRepository;
            }
        }

        public GenericRepository<PersonContexts, Type> TypeRepository
        {
            get
            {
                if (this.typeRepository == null)
                {
                    this.typeRepository = new GenericRepository<PersonContexts, Type>(context);
                }
                return typeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }
    }
}
