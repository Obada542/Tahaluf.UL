using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
   public class ContactService : IContactService
    {
        private readonly IContactulRepository contactulRepository;
        public ContactService(IContactulRepository _contactulRepository)
        {
            contactulRepository = _contactulRepository;
        }

       public List<Contactul> GetAllContactUl()
        {
            return contactulRepository.GetAllContactUl();
        }

        public bool CreateContactUl(Contactul contact)
        {
            return contactulRepository.CreateContactUl(contact);
        }
       public bool UpdateContactUl(Contactul contact)
        {
            return contactulRepository.UpdateContactUl(contact);

        }


        public bool DeleteContactUl(string mobile)
        {
            return contactulRepository.DeleteContactUl(mobile);
        }


    }
}
