using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface ILoginRepository
    {
        List<Loginul> GetAllLogins();
        int CreateLogin(Loginul loginul);
        bool UpdateLogin(Loginul loginul);
        string DeleteLogin(int id);
    }
}
