using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecommentController : ControllerBase
    {
        private readonly IRecommentService recommentService;

        public RecommentController(IRecommentService _recommentService)
        {
            recommentService = _recommentService;
        }

        [HttpPost]
        public bool CreateRecomment([FromBody] RecommentUL recomment)
        {
            return recommentService.CreateRecomment(recomment);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteRecomment(int id)
        {
            return recommentService.DeleteRecomment(id);
        }

        [HttpPut]
        public bool UpdateRecomment([FromBody] RecommentUL recomment)
        {
            return recommentService.UpdateRecomment(recomment);
        }

        [HttpGet,Route("{id}")]
        [ProducesResponseType(typeof(List<RecommentUL>), StatusCodes.Status200OK)] 
        public List<RecommentUL> GetAllRecomment(int id)
        {
            return recommentService.GetAllRecomment(id); 
        }
    }
}
