using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IBackgroundsulRepository
    {
        List<Backgroundsul> GetAllBackgroundUl();

        bool CreateBackgroungUl(Backgroundsul back);


        bool UpdateBackgroundUl(Backgroundsul back);


        bool DeleteBackgroundUl(string page);
    }
}
