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
        [Route("GetBackground")]
        public List<Backgroundsul> GetAllBackgroundUl()
        {
            return backgroundService.GetAllBackgroundUl();
        }

        [HttpPost]
        [Route("CreateBackground")]
        public bool CreateBackgroungUl([FromBody]Backgroundsul back)
        {
            return backgroundService.CreateBackgroungUl(back);
        }


        [HttpPatch]
        [Route("UpdateBackground")]
        public bool UpdateBackgroundUl([FromBody]Backgroundsul back)
        {
            return backgroundService.UpdateBackgroundUl(back);
        }

        [HttpDelete]
        [Route("DeleteBackground/{page}")]
        public bool DeleteBackgroundUl(string page)
        {
            return backgroundService.DeleteBackgroundUl(page);
        }




    }
}
