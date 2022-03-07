using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IAboutulRepository
    {
        List<Aboutul> GetAllAboutUl();

        bool CreateAbouttUl(Aboutul about);


        bool UpdateAbouttUl(Aboutul about);


        bool DeleteAbouttUl(string titl);
    }
}
