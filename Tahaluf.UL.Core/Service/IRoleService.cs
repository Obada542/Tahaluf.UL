using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IRoleService
    {
        List<Roleul> GetAllRoles();

        bool CreateRole(Roleul roleul);

        bool UpdateRole(Roleul roleul);

        string DeleteRole(int id);
    }
}
