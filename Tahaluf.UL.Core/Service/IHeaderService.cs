using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IHeaderService
    {
        List<Headerul> GetHeader();

        bool CreateHeader(Headerul headerul);

        bool UpdateHeader(Headerul headerul);

        string DeleteHeader();
    }
}
