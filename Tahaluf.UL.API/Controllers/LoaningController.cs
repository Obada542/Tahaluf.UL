using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaningController : ControllerBase
    {
        private readonly ILoaningService _loaningService;
        public LoaningController(ILoaningService _loaningService)
        {
            this._loaningService = _loaningService;
        }
        [HttpGet]
        public List<Loaningul> GetAllLoaning()
        {
            return _loaningService.GetAllLoaning();
        }
        [HttpPost]
        public string CreateLoanRequset([FromBody]Loaningul loaning)
        {
            return _loaningService.CreateLoanRequset(loaning);
        }
        [HttpPut]
        public string UpdateLoanRequset([FromBody] Loaningul loaning)
        {
            return _loaningService.UpdateLoanRequset(loaning);
        }
        [HttpGet,Route("SearchInterval")]
        public List<LoaningSearchDTO> GetAllLoaningByDates([FromBody]LoanSearchDatesDTO dates)
        {
            return _loaningService.GetAllLoaningByDates(dates);
        }
        [HttpGet,Route("StudentLoaning/{id}")]
        public List<StudentLoaningDTO> GetStudentLoaning(int id)
        {
            return _loaningService.GetStudentLoaning(id);
        }

    }
}
