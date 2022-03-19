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
    public class NewsRepository : INewsRepository
    {
        private readonly IDbContext _dbContext;
        public NewsRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public bool CreateNews(News news)
        {
            var p = new DynamicParameters();
            p.Add("header", news.Title,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("descrip", news.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pic", news.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var newss = _dbContext.Connection.ExecuteAsync("newsul_package.createnews",p ,commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteNews(int id)
        {
            var p = new DynamicParameters();
            p.Add("news_id", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var newss = _dbContext.Connection.ExecuteAsync("newsul_package.deletenews", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<News> GetAllNews()
        {
            var news = _dbContext.Connection.Query<News>("newsul_package.getallnews",commandType:CommandType.StoredProcedure);
            return news.ToList();
        }

        public bool UpdateNews(News news)
        {
            var p = new DynamicParameters();
            p.Add("news_id", news.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("header", news.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("descrip", news.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("pic", news.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var newss = _dbContext.Connection.ExecuteAsync("newsul_package.updatenews", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
