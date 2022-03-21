using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class LoaningService : ILoaningService
    {
        private readonly ILoaningRepository _loaningRepository;
        public LoaningService(ILoaningRepository _loaningRepository)
        {
            this._loaningRepository = _loaningRepository;
        }
        public string CreateBorrowingRequset(Loaningul loaning)
        {
            return _loaningRepository.CreateBorrowingRequset(loaning);
        }

        public List<Loaningul> GetAllBorrowings()
        {
           return _loaningRepository.GetAllBorrowings();
        }

        public List<Loaningul> GetBorrowingsByDates(LoanSearchDatesDTO dates)
        {
            return _loaningRepository.GetBorrowingsByDates(dates);
        }

        public string UpdateBorrowingRequset(Loaningul loaning)
        {
            return _loaningRepository.UpdateBorrowingRequset(loaning);
        }
        public List<StudentLoaningDTO> GetStudentBorrowing(int id)
        {
            return _loaningRepository.GetStudentBorrowing(id);
        }

    }
}
