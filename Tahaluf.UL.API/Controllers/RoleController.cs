using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService roleService;

        public RoleController(IRoleService _roleService)
        {
            roleService = _roleService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Roleul>), StatusCodes.Status200OK)]
        public List<Roleul> GetAllRoles()
        {
            return roleService.GetAllRoles();
        }

        [HttpPost]
        public bool CreateRole(Roleul roleul)
        {
            return roleService.CreateRole(roleul);
        }


        [HttpPut]
        [Route("Update/{id}")]
        public bool UpdateRole([FromBody] Roleul roleul)
        {
            return roleService.UpdateRole(roleul);
        }



        [HttpDelete]
        [Route("Delete/{id}")]
        public string DeleteCourse(int id)
        {
            return roleService.DeleteRole(id);
        }
    }
}
