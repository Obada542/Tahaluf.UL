using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountantController : ControllerBase
    {
        private readonly IAccountantService accountantService;

        public AccountantController(IAccountantService _accountantService)
        {
            accountantService = _accountantService;
        }

        [HttpPost]
        public bool CreateAccountant([FromBody] AccountantUL accountant)
        {
            return accountantService.CreateAccountant(accountant);

        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteAccountant(int id)
        {
            return accountantService.DeleteAccountant(id);
        }

        [HttpPut]
        public bool UpdateAccountant([FromBody] AccountantUL accountant)
        {
            return accountantService.UpdateAccountant(accountant);

        }

        [HttpGet]
        public List<AccountantUL> GetAllAccountants()
        {
            return accountantService.GetAllAccountants();
        }


    }
}
