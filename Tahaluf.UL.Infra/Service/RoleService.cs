using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository roleRepository;

        public RoleService(IRoleRepository _roleRepository)
        {
            roleRepository = _roleRepository;
        }


        public List<Roleul> GetAllRoles()
        {
            return roleRepository.GetAllRoles();
        }

        public bool CreateRole(Roleul roleul)
        {
            return roleRepository.CreateRole(roleul);
        }

        public bool UpdateRole(Roleul roleul)
        {
            return roleRepository.UpdateRole(roleul);
        }

        public string DeleteRole(int id)
        {
            return roleRepository.DeleteRole(id);
        }

    }
}
