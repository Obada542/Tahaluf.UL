using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Service
{
    public interface ILoaningService
    {
        List<Loaningul> GetAllLoaning();
        List<StudentLoaningDTO> GetStudentLoaning(int id);

        string CreateLoanRequset(Loaningul loaning);
        string UpdateLoanRequset(Loaningul loaning);
        List<LoaningSearchDTO> GetAllLoaningByDates(LoanSearchDatesDTO dates);

    }
}
