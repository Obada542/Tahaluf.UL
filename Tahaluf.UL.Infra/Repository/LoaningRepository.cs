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
        public List<Loaningul> GetAllBorrowings()
        {
            var loans = _dbContext.Connection.Query<Loaningul>("loaningul_package.getallborrowings", commandType:CommandType.StoredProcedure);
            return loans.ToList();
        }
        public string CreateBorrowingRequset(Loaningul loaning)
        {
            var p = new DynamicParameters();
            p.Add("endDate", loaning.End_Date, dbType: DbType.Date,direction:ParameterDirection.Input);
            p.Add("book", loaning.Book_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("student", loaning.Student_Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("p", loaning.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("bookName", loaning.Book_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("studentName", loaning.Student_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            var newloan = _dbContext.Connection.ExecuteAsync("loaningul_package.createborrowing", p, commandType: CommandType.StoredProcedure);
            return "Success.";
        }

        public string UpdateBorrowingRequset(Loaningul loaning)
        {
            var p = new DynamicParameters();
            p.Add("loan_id", loaning.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("isloand", loaning.Isloaned, dbType: DbType.String, direction: ParameterDirection.Input);
            var newloan = _dbContext.Connection.ExecuteAsync("loaningul_package.updateborrowing", p, commandType: CommandType.StoredProcedure);
            return "Success Update.";
        }
        public List<Loaningul> GetBorrowingsByDates(LoanSearchDatesDTO dates)
        {
            var p = new DynamicParameters();
            p.Add("enddate", dates.End_Date, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("startdate", dates.Start_Date, dbType: DbType.String, direction: ParameterDirection.Input);
            var loan = _dbContext.Connection.Query<Loaningul>("loaningul_package.searchinterval", p, commandType: CommandType.StoredProcedure);
            return loan.ToList();
        }
        public List<StudentLoaningDTO> GetStudentBorrowing(int id)
        {
            var p = new DynamicParameters();
            p.Add("studentid", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var loan = _dbContext.Connection.Query<StudentLoaningDTO>("loaningul_package.getstudentborrowings", p, commandType: CommandType.StoredProcedure);
            return loan.ToList();
        }
    }
}
