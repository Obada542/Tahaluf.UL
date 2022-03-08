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
        [ProducesResponseType(typeof(List<Loaningul>), StatusCodes.Status200OK)]
        public List<Loaningul> GetAllBorrowings()
        {
            return _loaningService.GetAllBorrowings();
        }

        [HttpPost]
        public string CreateBorrowingRequset([FromBody]Loaningul loaning)
        {
            return _loaningService.CreateBorrowingRequset(loaning);
        }

        [HttpPut]
        public string UpdateBorrowingRequset([FromBody] Loaningul loaning)
        {
            return _loaningService.UpdateBorrowingRequset(loaning);
        }

        [HttpGet,Route("SearchInterval")]
        [ProducesResponseType(typeof(List<LoaningSearchDTO>), StatusCodes.Status200OK)]
        public List<LoaningSearchDTO> GetBorrowingsByDates([FromBody]LoanSearchDatesDTO dates)
        {
            return _loaningService.GetBorrowingsByDates(dates);
        }

        [HttpGet,Route("StudentBorrowing/{id}")]
        [ProducesResponseType(typeof(List<StudentLoaningDTO>), StatusCodes.Status200OK)]
        public List<StudentLoaningDTO> GetStudentBorrowing(int id)
        {
            return _loaningService.GetStudentBorrowing(id);
        }

    }
}
