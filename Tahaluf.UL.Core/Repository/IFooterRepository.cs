using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
  public interface IFooterRepository
    {
        List<Footerul> GetAllFooterul();

        bool CreateFooterul(Footerul foter);


        bool UpdateFooterul(Footerul foter);


        bool DeleteFooterul(string F_BOOK);
    }
}
