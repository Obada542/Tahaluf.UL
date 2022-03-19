using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService _testimonialService)
        {
            this._testimonialService = _testimonialService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Testimonialul>), StatusCodes.Status200OK)]
        public List<Testimonialul> GetAllTestimonials()
        {
            return _testimonialService.GetAllTestimonials();
        }
        [HttpPost]
        public bool CreateTestimonial([FromBody] Testimonialul testimonial)
        {
            return _testimonialService.CreateTestimonial(testimonial);
        }
        [HttpPut]
        public bool UpdateTestimonial([FromBody] Testimonialul testimonial)
        {
            return _testimonialService.UpdateTestimonial(testimonial);
        }
    }
}
