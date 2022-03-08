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
        private readonly IDbContext DbContext;

        public AboutulRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public Aboutul GetAboutUl(Aboutul about)

        {
            var result = DbContext.Connection.QueryFirstOrDefault<Aboutul>("ABOUTUL_PACKAGE.GETALLABOUTTUL", commandType: CommandType.StoredProcedure);
            return result;

        }

      

        public bool UpdateAbouttUl(Aboutul about)
        {
            var p = new DynamicParameters();
            p.Add("About_Title", about.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_About_Title", about.Sub_Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", about.Descriptions, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("ABOUTUL_PACKAGE.UPDATEABOUTUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

      




    }
}
