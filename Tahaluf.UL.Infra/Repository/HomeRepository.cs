
using Dapper;
using Microsoft.EntityFrameworkCore;
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
   public class HomeRepository : IHomeRepository
    {
        private readonly IDbContext DbContext;

        public HomeRepository (IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

       public List<Homeul> GetAllSliders()
        {
            IEnumerable<Homeul> result = DbContext.Connection.Query<Homeul>("HOMEUL_PACKAGE.GETALLHOMEUL", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateSlider(Homeul slider)
        {
            var p = new DynamicParameters();
            p.Add("Home_Title", slider.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_Home_Title", slider.Sub_Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG", slider.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PTH", slider.Url, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("HOMEUL_PACKAGE.CREATEHOMEUL", p,commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateSlider(Homeul slider)
        {
            var p = new DynamicParameters();
            p.Add("h_id", slider.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Home_Title", slider.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_Home_Title", slider.Sub_Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("IMG", slider.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PTH", slider.Url, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("HOMEUL_PACKAGE.UPDATEHOMEUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteSlider(int id)
        {
            var p = new DynamicParameters();
            p.Add("H_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var slider = DbContext.Connection.ExecuteAsync("HOMEUL_PACKAGE.DELETEHOMEUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
