using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
   public interface IContactService
    {
        Contactul GetContact();
        bool UpdateContact(Contactul contact);
    }
}
