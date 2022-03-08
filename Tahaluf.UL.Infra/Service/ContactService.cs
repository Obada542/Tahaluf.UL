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
       public Contactul GetContact()
        {
            return contactulRepository.GetContact();
        }
       public bool UpdateContact(Contactul contact)
        {
            return contactulRepository.UpdateContact(contact);
        }
    }
}
