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
        [ProducesResponseType(typeof(List<Homeul>), StatusCodes.Status200OK)]
        [Route("GetSliders")]
        public List<Homeul> GetAllSliders()
        {
            return homeService.GetAllSliders();
        }

        [HttpPost]
        [Route("CreateSlider")]
        public bool CreateSlider([FromBody]Homeul slider)
        {
            return homeService.CreateSlider(slider);
        }

        [HttpPut]
        [Route("UpdateSlider")]
        public bool UpdateSlider([FromBody] Homeul slider)
        {
            return homeService.UpdateSlider(slider);
        }

        [HttpDelete]
        [Route("DeleteSlider/{id}")]
        public bool DeleteHomeul(int id)
        {
            return homeService.DeleteSlider(id);
        }
    }
}
