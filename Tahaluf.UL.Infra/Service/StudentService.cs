using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class StudentService : IStudentService
    {

        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }



        public bool CreateStudent(StudentUL student)
        {
            return _studentRepository.CreateStudent(student);
        }

        public bool DeleteStudent(int id)
        {
            return _studentRepository.DeleteStudent(id);
        }

        public List<StudentUL> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public bool UpdateStudent(StudentUL student)
        {
            return _studentRepository.UpdateStudent(student);
        }
    }
}
