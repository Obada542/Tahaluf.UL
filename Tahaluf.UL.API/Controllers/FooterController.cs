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
        [Route("GetFooter")]
       public Footerul GetFooterul()
        {
            return footerService.GetFooterul();
        }

        [HttpPatch]
        [Route("UpdateFooter")]
        public bool UpdateFooterul([FromBody]Footerul foter)
        {
            return footerService.UpdateFooterul(foter);
        }
       
    }
}
