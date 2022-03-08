using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class AccountantService : IAccountantService
    {
        private readonly IAccountantRepository _accountantRepository;

        public AccountantService(IAccountantRepository accountantRepository)
        {
            _accountantRepository = accountantRepository;
        }


        public bool CreateAccountant(AccountantUL accountant)
        {
            return _accountantRepository.CreateAccountant(accountant);
        }

        public bool DeleteAccountant(int id)
        {
            return _accountantRepository.DeleteAccountant(id);
        }

        public List<AccountantUL> GetAllAccountants()
        {
            return _accountantRepository.GetAllAccountants();
        }

        public bool UpdateAccountant(AccountantUL accountant)
        {
            return _accountantRepository.UpdateAccountant(accountant);
        }
    }

}
