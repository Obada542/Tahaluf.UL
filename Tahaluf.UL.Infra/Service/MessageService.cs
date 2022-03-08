using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class MessageService: IMessageService
    {
        private readonly IMessageRepository messageRepository;

        public MessageService(IMessageRepository _messageRepository)
        {
            messageRepository = _messageRepository;
        }


        public List<Messagesul> GetAllMessages()
        {
            return messageRepository.GetAllMessages();
        }


        public bool CreateMessage(Messagesul messagesul)
        {
            return messageRepository.CreateMessage(messagesul);
        }
    }
}
