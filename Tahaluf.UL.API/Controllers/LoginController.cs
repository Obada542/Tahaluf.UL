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
        public int CreateLogin([FromBody] Loginul login)
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
        [HttpPost]
        [Route("uploadImage")]
        public Loginul UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine(@"C:\Users\obada\Tahaluf.UL.Angular\src\assets\Images", fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Loginul Item = new Loginul();
                Item.Image = fileName;
                return Item;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
