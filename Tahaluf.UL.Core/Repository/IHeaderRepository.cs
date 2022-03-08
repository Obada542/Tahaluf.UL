using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IHeaderRepository
    {
        Headerul GetHeader();

        bool CreateHeader(Headerul headerul);

        bool UpdateHeader(Headerul headerul);

        string DeleteHeader();
    }
}
