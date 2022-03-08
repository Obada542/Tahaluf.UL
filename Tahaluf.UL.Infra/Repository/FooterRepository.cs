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
   public class FooterRepository : IFooterRepository
    {
        private readonly IDbContext dbContext;
        public FooterRepository (IDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Footerul GetFooter()
        {
            var result = dbContext.Connection.QueryFirstOrDefault<Footerul>("FOOTERUL_PACKAGE.GETALLFOOTERUL", commandType: CommandType.StoredProcedure);
            return result;
        }

       public bool UpdateFooter(Footerul footer)
        {
            var p = new DynamicParameters();
            p.Add("F_BOOK", footer.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Tweet", footer.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTA", footer.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", footer.Small_Desc, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("FOOTERUL_PACKAGE.UPDATEFOOTERUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
