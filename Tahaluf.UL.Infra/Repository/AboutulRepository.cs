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
    public class AboutulRepository : IAboutulRepository
    {
        private readonly IDbContext dbContext;

        public AboutulRepository(IDbContext _DbContext)
        {
            dbContext = _DbContext;
        }
        public Aboutul GetAboutUl()
        {
            var result = dbContext.Connection.QueryFirstOrDefault<Aboutul>("aboutul_package.getabout", commandType: CommandType.StoredProcedure);
            return result;

        }

        public bool UpdateAbouttUl(Aboutul about)
        {
            var p = new DynamicParameters();
            p.Add("About_Title", about.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_About_Title", about.Sub_Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", about.Descriptions, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.ExecuteAsync("aboutul_package.UPDATEABOUTUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
