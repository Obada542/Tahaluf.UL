using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Service
{
    public interface IJwtService
    {
        string Auth(Loginul loginul);

        bool SendEmail(Email email);

    }
}
