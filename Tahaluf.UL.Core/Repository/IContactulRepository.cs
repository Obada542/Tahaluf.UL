using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IContactulRepository
    {


        List<Contactul> GETALLCONTACTUL();

        bool CREATECONTACTUL(Contactul contact);


        bool UPDATECONTACTUL(Contactul contact);


        bool DELETECONTACTUL(string p);
    }
}

