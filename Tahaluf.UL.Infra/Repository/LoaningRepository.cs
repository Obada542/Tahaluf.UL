using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
    public class LoaningRepository : ILoaningRepository
    {
        private readonly IDbContext _dbContext;
        public LoaningRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public List<Loaningul> GetAllLoaning()
        {
            var loans = _dbContext.Connection.Query<Loaningul>("loaningul_package.getallloans",commandType:CommandType.StoredProcedure);
            return loans.ToList();
        }
        public string CreateLoanRequset(Loaningul loaning)
        {
            var p = new DynamicParameters();
            p.Add("endDate", loaning.End_Date, dbType: DbType.Date,direction:ParameterDirection.Input);
            p.Add("book", loaning.Book_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student", loaning.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var newloan = _dbContext.Connection.ExecuteAsync("loaningul_package.createloan",p, commandType: CommandType.StoredProcedure);
            return "Success.";
        }

        public string UpdateLoanRequset(Loaningul loaning)
        {
            var p = new DynamicParameters();
            p.Add("loan_id", loaning.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("isloand", loaning.Isloaned, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("f", loaning.Fines, dbType: DbType.Double, direction: ParameterDirection.Input);
            var newloan = _dbContext.Connection.ExecuteAsync("loaningul_package.updateloan", p, commandType: CommandType.StoredProcedure);
            return "Success Update.";
        }
        public List<LoaningSearchDTO> GetAllLoaningByDates(LoanSearchDatesDTO dates)
        {
            var p = new DynamicParameters();
            p.Add("enddate", dates.End_Date, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("startdate", dates.Start_Date, dbType: DbType.Date, direction: ParameterDirection.Input);

            var loan = _dbContext.Connection.Query<LoaningSearchDTO>("loaningul_package.searchinterval",p, commandType: CommandType.StoredProcedure);
            return loan.ToList();
        }
        public List<StudentLoaningDTO> GetStudentLoaning(int id)
        {
            var p = new DynamicParameters();
            p.Add("studentid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var loan = _dbContext.Connection.Query<StudentLoaningDTO>("loaningul_package.getstudentloans", p, commandType: CommandType.StoredProcedure);
            return loan.ToList();
        }

    }
}
