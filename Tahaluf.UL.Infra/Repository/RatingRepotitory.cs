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
    public class RatingRepository : IRatingRepository
    {
        private readonly IDbContext _dbContext;
        public RatingRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public List<Ratingul> GetBookRating(int id)
        {
            var p = new DynamicParameters();
            p.Add("book",id,dbType:DbType.Int32,direction:ParameterDirection.Input);
            var rates = _dbContext.Connection.Query<Ratingul>("rating_package.getbookrating", p,commandType:CommandType.StoredProcedure);
            return rates.ToList();
        }
        public string AddRating(Ratingul rate)
        {
            var p = new DynamicParameters();
            p.Add("r", rate.Rate, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("book", rate.Book_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student", rate.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);

            var rates = _dbContext.Connection.ExecuteAsync("rating_package.addrating", p, commandType: CommandType.StoredProcedure);
            return "Thanks.";
        }

        
    }
}
