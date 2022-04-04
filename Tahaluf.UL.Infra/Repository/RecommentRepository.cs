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
    public class RecommentRepository : IRecommentRepository
    {
        private readonly IDbContext DbContext;
        public RecommentRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }
        public bool CreateRecomment(RecommentUL recomment)
        {
            var p = new DynamicParameters();
            p.Add("SComment", recomment.Student_Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("book", recomment.Book_Id, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StudentId", recomment.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("CommentId", recomment.Comment_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<RecommentUL> result = DbContext.Connection.Query<RecommentUL>("RecommentUL_Package.CreateRecomment", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteRecomment(int id)
        {
            var p = new DynamicParameters();
            p.Add("RecommentId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("RecommentUL_Package.DeleteRecomment", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<RecommentUL> GetAllRecomment(int id)
        {
            var p = new DynamicParameters();
            p.Add("book", id, dbType: DbType.String, direction: ParameterDirection.Input);
            IEnumerable<RecommentUL> result = DbContext.Connection.Query<RecommentUL>("RecommentUL_Package.GetAllRecomment", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool UpdateRecomment(RecommentUL recomment)
        {
            var p = new DynamicParameters();
            p.Add("RecommentId", recomment.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SComment", recomment.Student_Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("RecommentUL_Package.UpdateRecomment ", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
