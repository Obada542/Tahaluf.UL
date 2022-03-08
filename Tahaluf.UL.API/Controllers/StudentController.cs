using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }

        [HttpPost]
        public bool CreateStudent([FromBody] StudentUL student)
        {
            return studentService.CreateStudent(student);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteStudent(int id)
        {
            return studentService.DeleteStudent(id);
        }

        [HttpPut]
        public bool UpdateStudent([FromBody] StudentUL student)
        {
            return studentService.UpdateStudent(student);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<StudentUL>), StatusCodes.Status200OK)]
        public List<StudentUL> GetAllStudents()
        {
            return studentService.GetAllStudents();
        }

    }
}
