using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
   public class BackgroundsulRepository : IBackgroundsulRepository
    {
        private readonly IDbContext DbContext;
        public BackgroundsulRepository (IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

       public List<Backgroundsul> GetAllBackgrounds()
        {
            IEnumerable<Backgroundsul> result = DbContext.Connection.Query<Backgroundsul>("BACKGROUNDSUL_PACKAGE.GETALLBACKGROUNDSUL", commandType: CommandType.StoredProcedure);
            
            return result.ToList();
        }

        public bool CreateBackground(Backgroundsul back)
        {
            var p = new DynamicParameters();
            p.Add("P_NAME", back.Page_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("B_GROUND", back.Background, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("BACKGROUNDSUL_PACKAGE.CREATEBACKGROUNDSUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateBackground(Backgroundsul back)
        {
            var p = new DynamicParameters();
            p.Add("P_NAME", back.Page_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("B_GROUND", back.Background, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("BACKGROUNDSUL_PACKAGE.UPDATEBACKGROUNDSUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

    }
}
