using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class ReportService : IReportService
    {
        private readonly IReportRepository _reportRepository;
        public ReportService(IReportRepository _reportRepository)
        {
            this._reportRepository = _reportRepository;
        }
        public List<ReportDTO> AnnualReport()
        {
            return _reportRepository.AnnualReport();
        }

        public List<ReportDTO> BookAnnualReport()
        {
            return _reportRepository.BookAnnualReport();
        }

        public List<ReportDTO> BookDailyReport()
        {
            return _reportRepository.BookDailyReport();
        }

        public List<ReportDTO> BookMonthlyReport()
        {
            return _reportRepository.BookMonthlyReport();
        }

        public int GetNewUsers()
        {
            return _reportRepository.GetNewUsers();
        }

        public List<ReportDTO> MonthlyReport()
        {
            return _reportRepository.MonthlyReport();
        }

        public List<EmployeesSalaryDTO> MonthlySalaryReport()
        {
            return _reportRepository.MonthlySalaryReport();
        }

        public ReportDTO Staitstics()
        {
            return _reportRepository.Staitstics();
        }
    }
}
