using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
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
        public List<LateFeesEmail> SendEmailForLateFees()
        {

            var result = DbContext.Connection.Query<LateFeesEmail>("loaningul_package.getlatefee", commandType: CommandType.StoredProcedure);
            if(result.Count() == 0)
            {
                return null;
            }
            DbContext.Connection.ExecuteAsync("loaningul_package.updateborrowingfines", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public Loginul Auth(Loginul loginul)
        {
            var p = new DynamicParameters();
            p.Add("mail", loginul.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PASS", loginul.Password, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Loginul> result = DbContext.Connection.Query<Loginul>("LOGINUSER.login", p, commandType: CommandType.StoredProcedure);
            return result.FirstOrDefault();
        }
    }
}
