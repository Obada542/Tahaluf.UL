using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
   public interface IAboutService
    {
        List<Aboutul> GetAllAboutUl();

        bool CreateAboutUl(Aboutul about);


        bool UpdateAbouttUl(Aboutul about);


        bool DeleteAbouttUl(string titl);
    }
}
