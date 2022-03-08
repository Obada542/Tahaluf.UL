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
    public class HeaderRepository: IHeaderRepository
    {
        private readonly IDbContext DbContext;

        public HeaderRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }



        public Headerul GetHeader()
        {
            var result = DbContext.Connection.QueryFirstOrDefault<Headerul>("HeaderPackage.GETHEADER", commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool CreateHeader(Headerul headerul)
        {
            var p = new DynamicParameters();
            p.Add("t", headerul.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("l", headerul.Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("HeaderPackage.CREATEHEADER", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateHeader(Headerul headerul)
        {
            var p = new DynamicParameters();
            p.Add("t", headerul.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("l", headerul.Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("HeaderPackage.UPDATEHEADER", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public string DeleteHeader()
        {
            var result = DbContext.Connection.ExecuteAsync("HeaderPackage.DELETEHEADER", commandType: CommandType.StoredProcedure);
            return "Deleted Successfully";
        }
    }
}
