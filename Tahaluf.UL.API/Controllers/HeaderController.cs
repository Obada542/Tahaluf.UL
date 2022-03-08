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
    public class HeaderController : ControllerBase
    {
        private readonly IHeaderService headerService;

        public HeaderController(IHeaderService _headerService)
        {
            headerService = _headerService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Headerul), StatusCodes.Status200OK)]
        public Headerul GetHeader()
        {
            return headerService.GetHeader();
        }

        [HttpPut]
        [Route("Update")]
        public bool UpdateHeader([FromBody]Headerul headerul)
        {
            return headerService.UpdateHeader(headerul);
        }

    }
}
