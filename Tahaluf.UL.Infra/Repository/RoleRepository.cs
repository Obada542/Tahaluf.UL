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
    public class RoleRepository: IRoleRepository
    {
        private readonly IDbContext DbContext;
        public RoleRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public List<Roleul> GetAllRoles()
        {
            IEnumerable<Roleul> result = DbContext.Connection.Query<Roleul>("RolePackage.GETROLE", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateRole(Roleul roleul)
        {
            var p = new DynamicParameters();
            p.Add("ROLENAME", roleul.Role_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("RolePackage.CREATEROLE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateRole(Roleul roleul)
        {
            var p = new DynamicParameters();
            p.Add("ROLEID", roleul.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("ROLENAME", roleul.Role_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("RolePackage.UPDATEROLE", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public string DeleteRole(int id)
        {
            var p = new DynamicParameters();
            p.Add("ROLEID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("RolePackage.DELETEROLE", p, commandType: CommandType.StoredProcedure);
            return "Deleted Successfully";
        }
    }
}
