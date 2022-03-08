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
        private readonly IDbContext DbContext;
        public FooterRepository (IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Footerul> GetAllFooterul()
        {
            IEnumerable<Footerul> result = DbContext.Connection.Query<Footerul>("FOOTERUL_PACKAGE.GETALLFOOTERUL", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

       public bool CreateFooterul(Footerul foter)
        {
            var p = new DynamicParameters();
            p.Add("F_BOOK", foter.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Tweet", foter.Twitter, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("INSTA", foter.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", foter.SmallDesc, dbType: DbType.Double, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("FOOTERUL_PACKAGE.CREATEFOOTERUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

       public bool UpdateFooterul(Footerul foter)
        {
            var p = new DynamicParameters();
            p.Add("F_BOOK", foter.Facebook, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Tweet", foter.Twitter, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("INSTA", foter.Instagram, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("DESCRP", foter.SmallDesc, dbType: DbType.Double, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("FOOTERUL_PACKAGE.UPDATEFOOTERUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteFooterul(string F_BOOK)
        {
            var p = new DynamicParameters();
            p.Add("F_BOOK", F_BOOK, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("FOOTERUL_PACKAGE.DELETEFOOTERUL", p, commandType: CommandType.StoredProcedure);
            return true;

        }



    }
}
