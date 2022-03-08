using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
   public interface IBackgroundsulRepository
    {
        List<Backgroundsul> GetAllBackgrounds();
        bool CreateBackground(Backgroundsul back);
        bool UpdateBackground(Backgroundsul back);
    }
}
