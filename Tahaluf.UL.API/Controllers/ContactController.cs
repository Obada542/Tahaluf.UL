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
        [Route("GetContacts")]
        public List<Contactul> GetAllContactUl()
        {
            return contactService.GetAllContactUl();
        }

        [HttpPost]
        [Route("CreateContact")]
        public bool CreateContactUl([FromBody] Contactul contact)
        {
            return contactService.CreateContactUl(contact);
        }

        [HttpPatch]
        [Route("UpdateContact")]
        public bool UpdateContactUl([FromBody] Contactul contact)
        {
            return contactService.UpdateContactUl(contact);

        }

        [HttpDelete]
        [Route("Delete/{mobile}")]
        public bool DeleteContactUl(string mobile)
        {
            return contactService.DeleteContactUl(mobile);
        }

    }
}
