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
    public class BackgroundController : ControllerBase
    {
        private readonly IBackgroundService backgroundService;

        public BackgroundController(IBackgroundService _backgroundService)
        {
            backgroundService = _backgroundService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Backgroundsul>), StatusCodes.Status200OK)]
        [Route("GetBackground")]
        public List<Backgroundsul> GetAllBackgrounds()
        {
            return backgroundService.GetAllBackgrounds();
        }

        [HttpPost]
        [Route("CreateBackground")]
        public bool CreateBackground([FromBody] Backgroundsul back)
        {
            return backgroundService.CreateBackground(back);
        }

        [HttpPut]
        [Route("UpdateBackground")]
        public bool UpdateBackground([FromBody] Backgroundsul back)
        {
            return backgroundService.UpdateBackground(back);
        }

    }
}
