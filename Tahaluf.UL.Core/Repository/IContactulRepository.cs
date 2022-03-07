using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IContactulRepository
    {


        List<Contactul> GetAllContactUl();

        bool CreateContactUl(Contactul contact);


        bool UpdateContactUl(Contactul contact);


        bool DeleteContactUl(string p);
    }
}

