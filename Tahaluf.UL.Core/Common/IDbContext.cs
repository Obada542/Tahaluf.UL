using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Tahaluf.UL.Core.Common
{
    public interface IDbContext
    {
            DbConnection Connection { get; }
    }
}
