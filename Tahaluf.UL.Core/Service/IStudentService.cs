using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IStudentService
    {
        List<StudentUL> GetAllStudents();

        bool CreateStudent(StudentUL student);

        bool UpdateStudent(StudentUL student);

        bool DeleteStudent(int id);

    }
}
