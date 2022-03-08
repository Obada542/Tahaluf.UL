using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService loginService;

        public LoginController(ILoginService _loginService)
        {
            loginService = _loginService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Loginul>), StatusCodes.Status200OK)]
        public List<Loginul> GetAllLogins()
        {
            return loginService.GetAllLogins();
        }

        [HttpPost]
        public bool CreateLogin([FromBody] Loginul login)
        {
            return loginService.CreateLogin(login);
        }

        [HttpPut]
        [Route("Update")]
        public bool UpdateLogin([FromBody] Loginul login)
        {
            return loginService.UpdateLogin(login);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public string DeleteLogin(int id)
        {
            return loginService.DeleteLogin(id);
        }

    }
}
