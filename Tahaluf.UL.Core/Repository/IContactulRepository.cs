using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IContactulRepository
    {


        Contactul GetContactUl(Contactul contact);

        


        bool UpdateContactUl(Contactul contact);


       
    }
}

