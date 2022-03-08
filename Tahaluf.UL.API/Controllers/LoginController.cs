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
        public bool CreateLogin(Loginul loginul)
        {
            return loginService.CreateLogin(loginul);
        }


        [HttpPut]
        [Route("Update/{id}")]
        public bool UpdateLogin([FromBody] Loginul loginul)
        {
            return loginService.UpdateLogin(loginul);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public string DeleteLogin(int id)
        {
            return loginService.DeleteLogin(id);
        }

        //IMAGE
        [HttpPost]
        [Route("Upload")]
        public Loginul Upload()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine("Images", fileName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                //DataBase
                Loginul login = new Loginul();
                login.Image = fileName;
                return login;
            }

            catch (Exception e)
            {
                return null;
            }
        }

    }
}
