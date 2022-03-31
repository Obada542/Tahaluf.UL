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
    public class LoginRepository: ILoginRepository
    {
        private readonly IDbContext DbContext;

        public LoginRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Loginul> GetAllLogins()
        {
            IEnumerable<Loginul> result = DbContext.Connection.Query<Loginul>("LOGIN_PACKAGE.GETALLLOGINS", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public int CreateLogin(Loginul login)
        {
            var p = new DynamicParameters();
            p.Add("UNAME", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASS", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL1", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTH", login.Birthday, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("IMG", login.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEL", login.Phone, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("ROLEID ", login.Role_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("LOGIN_PACKAGE.CREATELOGIN", p, commandType: CommandType.StoredProcedure);
            var email = new DynamicParameters();
            email.Add("eemail", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            var id = DbContext.Connection.QueryFirstOrDefault<Loginul>("LOGIN_PACKAGE.GETIDBYEMAIL", email, commandType: CommandType.StoredProcedure);
            return id.Id;
        }

        public bool UpdateLogin(Loginul login)
        {
            var p = new DynamicParameters();
            p.Add("logId", login.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("UNAME", login.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASS", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("EMAIL1", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("BIRTH", login.Birthday, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("IMG", login.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("TEL", login.Phone, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("LOGIN_PACKAGE.UPDATELOGIN", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public string DeleteLogin(int id)
        {
            var p = new DynamicParameters();
            p.Add("logId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("LOGIN_PACKAGE.DELETELOGIN", p, commandType: CommandType.StoredProcedure);
            return "Deleted Successfully";
        }

    }
}
