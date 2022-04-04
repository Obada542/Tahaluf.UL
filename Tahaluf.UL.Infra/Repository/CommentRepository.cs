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
    public class CommentRepository : ICommentRepository
    {
        private readonly IDbContext DbContext;


        public CommentRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateComment(CommentUL comment)
        {
            var p = new DynamicParameters();
            p.Add("SComment", comment.Student_Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StudentId", comment.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BookId", comment.Book_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CommentUL> result = DbContext.Connection.Query<CommentUL>("CommentUL_Package.CreateComment", p, commandType: CommandType.StoredProcedure);

            return true;
        }

        public bool DeleteComment(int id)
        {
            var p = new DynamicParameters();
            p.Add("CommentId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("CommentUL_Package.DeleteComment", p, commandType: CommandType.StoredProcedure);
            return true;

        }
        public List<CommentUL> GetAllComment(int id)
        {
            var p = new DynamicParameters();
            p.Add("bookid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<CommentUL> result = DbContext.Connection.Query<CommentUL>("CommentUL_Package.GetAllComment",p, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool UpdateComment(CommentUL comment)
        {
            var p = new DynamicParameters();
            p.Add("CommentId", comment.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("SComment", comment.Student_Comment, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("StudentId", comment.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("BookId", comment.Book_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CommentUL_Package.UpdateComment", p, commandType: CommandType.StoredProcedure);

            return true;
        }
    }
}
