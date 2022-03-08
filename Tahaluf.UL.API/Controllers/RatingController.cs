using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        public RatingController(IRatingService _ratingService)
        {
            this._ratingService = _ratingService;
        }

        [HttpGet,Route("{id}")]
        [ProducesResponseType(typeof(List<Ratingul>), StatusCodes.Status200OK)]
        public List<Ratingul> GetBookRating(int id)
        {
            return _ratingService.GetBookRating(id);
        }

        [HttpPost]
        public string AddRating([FromBody] Ratingul rate)
        {
            return _ratingService.AddRating(rate);
        }
    }
}
