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
    public class JwtRepository: IJwtRepository
    {
        private readonly IDbContext DbContext;

        public JwtRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public Loginul Auth(Loginul loginul)
        {
            var p = new DynamicParameters();
            p.Add("UNAME", loginul.Username, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASS", loginul.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Loginul> result = DbContext.Connection.Query<Loginul>("LOGIN_USER", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
        public Roleul GetRoleNameById(int? id)
        {
            var p = new DynamicParameters();
            p.Add("ROLEID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.QueryFirstOrDefault<Roleul>("RolePackage.getrolenamebyid", p, commandType: CommandType.StoredProcedure);
            return result;
        }
    }
}
