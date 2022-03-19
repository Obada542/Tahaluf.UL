using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface ITestimonialService
    {
        List<Testimonialul> GetAllTestimonials();
        bool CreateTestimonial(Testimonialul testimonial);
        bool UpdateTestimonial(Testimonialul testimonial);

    }
}
