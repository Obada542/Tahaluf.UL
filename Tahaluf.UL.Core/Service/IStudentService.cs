using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Service
{
    public interface IStudentService
    {
        List<StudentUL> GetAllStudents();

        bool CreateStudent(StudentUL student);

        bool UpdateStudent(StudentUL student);
        StudentLoginDTO GetStudentLoginDetails(int loginid);

        bool DeleteStudent(int id);

    }
}
