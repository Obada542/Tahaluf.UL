using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface ILoginService
    {
        List<Loginul> GetAllLogins();

        int CreateLogin(Loginul loginul);

        bool UpdateLogin(Loginul loginul);

        string DeleteLogin(int id);
    }
}
