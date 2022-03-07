using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
   public interface IContactService
    {
        List<Contactul> GetAllContactUl();

        bool CreateContactUl(Contactul contact);


        bool UpdateContactUl(Contactul contact);


        bool DeleteContactUl(string mobile);
    }
}
