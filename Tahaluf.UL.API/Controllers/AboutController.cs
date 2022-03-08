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
       public Aboutul GetAboutUl()
        {
            return aboutService.GetAboutUl();
        }

        [HttpPatch]
        [Route("UpdateAbout")]
        public bool UpdateAbouttUl([FromBody]Aboutul about)
        {
            return aboutService.UpdateAbouttUl(about);
        }

        


    }
}
