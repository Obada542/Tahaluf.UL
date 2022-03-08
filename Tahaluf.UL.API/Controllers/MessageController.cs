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
    public class MessageController : ControllerBase
    {
        private readonly IMessageService messageService;

        public MessageController(IMessageService _messageService)
        {
            messageService = _messageService;
        }


        [HttpGet]
        [ProducesResponseType(typeof(List<Messagesul>), StatusCodes.Status200OK)]
        public List<Messagesul> GetAllMessages()
        {
            return messageService.GetAllMessages();
        }


        [HttpPost]
        public bool CreateMessage(Messagesul messagesul)
        {
            return messageService.CreateMessage(messagesul);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public string DeleteMessage(int id)
        {
            return messageService.DeleteMessage(id);
        }

    }
}
