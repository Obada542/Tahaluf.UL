using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IReportService _reportService;
        public ReportController(IReportService _reportService)
        {
            this._reportService = _reportService;
        }
        [HttpGet,Route("AnnualReport")]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        public List<ReportDTO> AnnualReport()
        {
            return _reportService.AnnualReport();
        }
        [HttpGet, Route("BookAnnualReport")]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        public List<ReportDTO> BookAnnualReport()
        {
            return _reportService.BookAnnualReport();
        }
        [HttpGet, Route("BookDailyReport")]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        public List<ReportDTO> BookDailyReport()
        {
            return _reportService.BookDailyReport();
        }
        [HttpGet, Route("BookMonthlyReport")]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        public List<ReportDTO> BookMonthlyReport()
        {
            return _reportService.BookMonthlyReport();
        }
        [HttpGet, Route("GetNewUsers")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        public int GetNewUsers()
        {
            return _reportService.GetNewUsers();
        }
        [HttpGet, Route("MonthlyReport")]
        [ProducesResponseType(typeof(List<ReportDTO>), StatusCodes.Status200OK)]
        public List<ReportDTO> MonthlyReport()
        {
            return _reportService.MonthlyReport();
        }
        [HttpGet, Route("Staitstics")]
        [ProducesResponseType(typeof(ReportDTO), StatusCodes.Status200OK)]
        public ReportDTO Staitstics()
        {
            return _reportService.Staitstics();
        }
        [HttpGet, Route("MonthlySalaryReport")]
        [ProducesResponseType(typeof(List<EmployeesSalaryDTO>), StatusCodes.Status200OK)]
        public List<EmployeesSalaryDTO> MonthlySalaryReport()
        {
            return _reportService.MonthlySalaryReport();
        }
    }
}
