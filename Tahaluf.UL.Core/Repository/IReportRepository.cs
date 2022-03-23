using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Repository
{
    public interface IReportRepository
    {
        int GetNewUsers();
        ReportDTO Staitstics();
        List<ReportDTO> AnnualReport();
        List<ReportDTO> MonthlyReport();
        List<ReportDTO> BookDailyReport();
        List<ReportDTO> BookAnnualReport();
        List<ReportDTO> BookMonthlyReport();
        List<EmployeesSalaryDTO> MonthlySalaryReport();
    }
}
