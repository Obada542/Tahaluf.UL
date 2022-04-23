using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Dapper;
using System.Data;

namespace Tahaluf.UL.Infra.Repository
{
    public class PaymentRepository : IPaymentRepository
    {
        private readonly IDbContext _dbContext;
        public PaymentRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        } 
        public bool ChangeAmoutCard(Payment payment)  
        { 
            var p = new DynamicParameters();
            p.Add("card", payment.Card_Number, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("price", payment.Amount, dbType: DbType.Double, direction: ParameterDirection.Input);
            _dbContext.Connection.ExecuteAsync("visaul_package.pay", p, commandType: CommandType.StoredProcedure);
            return true;
        }
         
        public float GetCard(Payment payment) 
        {
            var p = new DynamicParameters();
            p.Add("card", payment.Card_Number, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("expiry", payment.Expired_Date, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("cv", payment.Cvv, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var amount = _dbContext.Connection.QueryFirstOrDefault<float>("visaul_package.get_payment", p, commandType: CommandType.StoredProcedure);

            return amount;
        }
        public bool PayFines(int id)
        {
            var p = new DynamicParameters();
            p.Add("student", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            _dbContext.Connection.ExecuteAsync("loaningul_package.payfines", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
