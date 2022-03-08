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
    public class FooterController : ControllerBase
    {
        private readonly IFooterService footerService;
        public FooterController (IFooterService _footerService)
        {
            footerService = _footerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Footerul), StatusCodes.Status200OK)]
        [Route("GetFooter")]
       public Footerul GetFooter()
        {
            return footerService.GetFooter();
        }

        [HttpPut]
        [Route("UpdateFooter")]
        public bool UpdateFooter([FromBody] Footerul footer)
        {
            return footerService.UpdateFooter(footer);
        }
       
    }
}
