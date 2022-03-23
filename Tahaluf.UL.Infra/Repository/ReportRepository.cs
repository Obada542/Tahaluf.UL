using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly IDbContext _dbContext;
        public ReportRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public List<ReportDTO> AnnualReport()
        {
            return _dbContext.Connection.Query<ReportDTO>("report_package.annualreport",commandType:CommandType.StoredProcedure).ToList();
        }

        public List<ReportDTO> BookAnnualReport()
        {
            return _dbContext.Connection.Query<ReportDTO>("report_package.bookannualreport", commandType: CommandType.StoredProcedure).ToList();
        }

        public List<ReportDTO> BookDailyReport()
        {
            return _dbContext.Connection.Query<ReportDTO>("report_package.bookdailyreport", commandType: CommandType.StoredProcedure).ToList();

        }

        public List<ReportDTO> BookMonthlyReport()
        {
            return _dbContext.Connection.Query<ReportDTO>("report_package.bookmonthlyreport", commandType: CommandType.StoredProcedure).ToList();

        }

        public int GetNewUsers()
        {
            return _dbContext.Connection.QueryFirstOrDefault<int>("report_package.getnewusers", commandType: CommandType.StoredProcedure);
        }

        public List<ReportDTO> MonthlyReport()
        {
            return _dbContext.Connection.Query<ReportDTO>("report_package.monthlyreport", commandType: CommandType.StoredProcedure).ToList();
        }

        public List<EmployeesSalaryDTO> MonthlySalaryReport()
        {
            return _dbContext.Connection.Query<EmployeesSalaryDTO>("report_package.employeessalary", commandType: CommandType.StoredProcedure).ToList();
        }

        public ReportDTO Staitstics()
        {
            return _dbContext.Connection.QueryFirstOrDefault<ReportDTO>("report_package.staitstics", commandType: CommandType.StoredProcedure);
        }
    }
}
