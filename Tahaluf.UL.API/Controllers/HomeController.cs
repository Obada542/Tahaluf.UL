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
    public class HomeController : ControllerBase
    {
        private readonly IHomeService homeService;
        public HomeController(IHomeService _homeService)
        {
            homeService = _homeService;
        }

        [HttpGet]
        [Route("GetHom")]
        public List<Homeul> GetAllHomeul()
        {
            return homeService.GetAllHomeul();
        }

        [HttpPost]
        [Route("CreateHome")]
        public bool CreateHomeul([FromBody]Homeul hom)
        {
            return homeService.CreateHomeul(hom);
        }

        [HttpPatch]
        [Route("UpdateHome")]
        public bool UpdateHomeul([FromBody]Homeul hom)
        {
            return homeService.UpdateHomeul(hom);
        }

        [HttpDelete]
        [Route("DeleteHome/{id}")]
        public bool DeleteHomeul(int id)
        {
            return homeService.DeleteHomeul(id);
        }
    }
}
