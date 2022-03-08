using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
  public interface IFooterRepository
    {
        Footerul GetFooterul(Footerul foter);

        bool UpdateFooterul(Footerul foter);


       
    }
}
