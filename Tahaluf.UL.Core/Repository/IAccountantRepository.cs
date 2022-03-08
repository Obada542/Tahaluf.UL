using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IAccountantRepository
    {
        List<AccountantUL> GetAllAccountants();
        bool CreateAccountant(AccountantUL accountant);
        bool UpdateAccountant(AccountantUL accountant);
        bool DeleteAccountant(int id);

    }
}
