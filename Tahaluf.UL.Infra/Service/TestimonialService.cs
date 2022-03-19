using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class TestimonialService : ITestimonialService
    {
        private readonly ITestimonialRepository _testimonialRepository;
        public TestimonialService(ITestimonialRepository _testimonialRepository)
        {
            this._testimonialRepository = _testimonialRepository;
        }

        public bool CreateTestimonial(Testimonialul testimonial)
        {
            return _testimonialRepository.CreateTestimonial(testimonial);
        }

        public List<Testimonialul> GetAllTestimonials()
        {
            return _testimonialRepository.GetAllTestimonials();
        }

        public bool UpdateTestimonial(Testimonialul testimonial)
        {
            return _testimonialRepository.UpdateTestimonial(testimonial);
        }
    }
}
