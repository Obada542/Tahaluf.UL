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
        public string CreateLoanRequset(Loaningul loaning)
        {
            return _loaningRepository.CreateLoanRequset(loaning);
        }

        public List<Loaningul> GetAllLoaning()
        {
           return _loaningRepository.GetAllLoaning();
        }

        public List<LoaningSearchDTO> GetAllLoaningByDates(LoanSearchDatesDTO dates)
        {
            return _loaningRepository.GetAllLoaningByDates(dates);
        }

        public string UpdateLoanRequset(Loaningul loaning)
        {
            return _loaningRepository.UpdateLoanRequset(loaning);
        }
        public List<StudentLoaningDTO> GetStudentLoaning(int id)
        {
            return _loaningRepository.GetStudentLoaning(id);
        }

    }
}
