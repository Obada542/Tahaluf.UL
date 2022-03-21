using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Service
{
    public interface ILoaningService
    {
        List<Loaningul> GetAllBorrowings();
        List<StudentLoaningDTO> GetStudentBorrowing(int id);
        string CreateBorrowingRequset(Loaningul loaning);
        string UpdateBorrowingRequset(Loaningul loaning);
        List<Loaningul> GetBorrowingsByDates(LoanSearchDatesDTO dates);

    }
}
