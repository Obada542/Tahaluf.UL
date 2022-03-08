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
    public class AccountantRepository : IAccountantRepository
    {
        private readonly IDbContext DbContext;


        public AccountantRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public bool CreateAccountant(AccountantUL accountant)
        {
            var p = new DynamicParameters();
            p.Add("Sal", accountant.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Addres", accountant.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LoginId", accountant.Login_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);


            IEnumerable<AccountantUL> result = DbContext.Connection.Query<AccountantUL>("AccountantUL_Package.CreateAccountant", p, commandType: CommandType.StoredProcedure);

            return true;

        }

        public bool DeleteAccountant(int id)
        {
            var p = new DynamicParameters();
            p.Add("AccountantId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            DbContext.Connection.ExecuteAsync("AccountantUL_Package.DeleteAccountant", p, commandType: CommandType.StoredProcedure);
            return true;

        }

        public List<AccountantUL> GetAllAccountants()
        {
            IEnumerable<AccountantUL> result = DbContext.Connection.Query<AccountantUL>("AccountantUL_Package.GetAllAccountant", commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public bool UpdateAccountant(AccountantUL accountant)
        {
            var p = new DynamicParameters();

            p.Add("AccountantId", accountant.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Sal", accountant.Salary, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("Addres", accountant.Address, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LoginId", accountant.Login_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("AccountantUL_Package.UpdateAccountant", p, commandType: CommandType.StoredProcedure);

            return true;


        }
    }
}
