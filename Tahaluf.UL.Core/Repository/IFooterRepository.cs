using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
  public interface IFooterRepository
    {
        Footerul GetFooter();
        bool UpdateFooter(Footerul foter);
    }
}
