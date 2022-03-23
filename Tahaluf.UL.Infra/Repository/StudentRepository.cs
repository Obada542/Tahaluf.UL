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
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbContext DbContext;
        public StudentRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateStudent(StudentUL student)
        {
            var p = new DynamicParameters();
            p.Add("FirstName", student.First_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LastName", student.Last_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LoginId", student.Login_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<StudentUL> result = DbContext.Connection.Query<StudentUL>("StudentUL_Package.CreateStudent", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteStudent(int id)
        {
            var p = new DynamicParameters();
            p.Add("StudentId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("StudentUL_Package.DeleteStudent", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<StudentUL> GetAllStudents()
        {
            IEnumerable<StudentUL> result = DbContext.Connection.Query<StudentUL>("StudentUL_Package.GetAllStudent", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateStudent(StudentUL student)
        {
            var p = new DynamicParameters();
            p.Add("StudentId", student.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("FirstName", student.First_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LastName", student.Last_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("StudentUL_Package.updatestudent", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
