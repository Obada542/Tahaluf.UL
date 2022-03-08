using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {

        private readonly IContactService contactService;
        public ContactController (IContactService _contactService)
        {
            contactService = _contactService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(Contactul), StatusCodes.Status200OK)]
        [Route("GetContact")]
        public Contactul GetContact()
        {
            return contactService.GetContact();
        }

        [HttpPut]
        [Route("UpdateContact")]
        public bool UpdateContact([FromBody] Contactul contact)
        {
            return contactService.UpdateContact(contact);

        }

    }
}
