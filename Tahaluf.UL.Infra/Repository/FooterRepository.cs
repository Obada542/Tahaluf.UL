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

        public Footerul GetFooterul()
        {
         var result = dbContext.Connection.QueryFirstOrDefault<Footerul>("FOOTERUL_PACKAGE.GETALLFOOTERUL", commandType: CommandType.StoredProcedure);

            return result;

        }

       public bool UpdateFooterul(Footerul foter)
        {
            var p = new DynamicParameters();
            p.Add("F_BOOK", foter.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Tweet", foter.Twitter, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("INSTA", foter.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", foter.Small_Desc, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = dbContext.Connection.ExecuteAsync("FOOTERUL_PACKAGE.UPDATEFOOTERUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

       
    }
}
