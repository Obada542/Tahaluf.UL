using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IAccountantService
    {

        List<AccountantUL> GetAllAccountants();

        bool CreateAccountant(AccountantUL accountant);

        bool UpdateAccountant(AccountantUL accountant);

        bool DeleteAccountant(int id);

    }
}
