using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Repository
{
    public interface IStudentRepository
    {
        List<StudentUL> GetAllStudents();
        bool CreateStudent(StudentUL student);
        bool UpdateStudent(StudentUL student);
        bool DeleteStudent(int id);
        StudentLoginDTO GetStudentLoginDetails(int loginid);

    }
}
