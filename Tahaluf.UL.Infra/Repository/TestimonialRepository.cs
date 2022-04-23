using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly IDbContext _dbContext;
        public TestimonialRepository(IDbContext _dbContext) 
        {
            this._dbContext = _dbContext;
        }

        public bool CreateTestimonial(Testimonialul testimonial)
        {
            var p = new DynamicParameters();
            p.Add("fullname",testimonial.Name,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("star", testimonial.Rate, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("comment", testimonial.Testimonial, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("student", testimonial.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var testimonials = _dbContext.Connection.ExecuteAsync("testimonialul_package.createtestimonial",p,commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Testimonialul> GetAllTestimonials()
        {
            var testimonials = _dbContext.Connection.Query<Testimonialul>("testimonialul_package.getalltestimonial", commandType:System.Data.CommandType.StoredProcedure);
            return testimonials.ToList();
        }

        public bool UpdateTestimonial(Testimonialul testimonial)
        {
            var p = new DynamicParameters();
            p.Add("testimonial_id", testimonial.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("show", testimonial.Publishing, dbType: DbType.String, direction: ParameterDirection.Input);
            var testimonials = _dbContext.Connection.ExecuteAsync("testimonialul_package.updatetestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
