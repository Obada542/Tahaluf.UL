using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IMessageRepository 
    { 
        List<Messagesul> GetAllMessages(); 
        bool CreateMessage(Messagesul messagesul);  
        string DeleteMessage(int id); 
    }
} 
