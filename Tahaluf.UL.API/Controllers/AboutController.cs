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
    public class AboutController : ControllerBase
    {
        private readonly IAboutService aboutService;
        public AboutController (IAboutService _aboutService)
        {
            aboutService = _aboutService;
        }

        [HttpGet]
        [Route("AboutUl")]
       public List<Aboutul> GetAllAboutUl()
        {
            return aboutService.GetAllAboutUl();
        }

        [HttpPost]
        [Route("CreateAbout")]
       public bool CreateAboutUl([FromBody] Aboutul about)
        {
            return aboutService.CreateAboutUl(about);
        }

        [HttpPatch]
        [Route("UpdateAbout")]
        public bool UpdateAbouttUl([FromBody]Aboutul about)
        {
            return aboutService.UpdateAbouttUl(about);
        }

        [HttpDelete]
        [Route("DeleteAbout/{titl}")]
        public bool DeleteAbouttUl(string titl)
        {
            return aboutService.DeleteAbouttUl(titl);
        }



    }
}
