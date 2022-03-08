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
        [ProducesResponseType(typeof(Aboutul), StatusCodes.Status200OK)]
        [Route("AboutUl")]
       public Aboutul GetAbout()
        {
            return aboutService.GetAbout();
        }

        [HttpPut]
        [Route("UpdateAbout")]
        public bool UpdateAbout([FromBody]Aboutul about)
        {
            return aboutService.UpdateAbout(about);
        }

    }
}
