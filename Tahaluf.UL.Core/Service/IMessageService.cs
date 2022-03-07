using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IMessageService
    {
        List<Messagesul> GetAllMessages();

        bool CreateMessage(Messagesul messagesul);
    }
}
