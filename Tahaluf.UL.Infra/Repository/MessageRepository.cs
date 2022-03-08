using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.UL.Core.Common;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;

namespace Tahaluf.UL.Infra.Repository
{
    public class MessageRepository: IMessageRepository
    {
        private readonly IDbContext DbContext;

        public MessageRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }


        public List<Messagesul> GetAllMessages()
        {
            IEnumerable<Messagesul> result = DbContext.Connection.Query<Messagesul>("MESSAGE_PACKAGE.GETALLMESSAGES", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }


        public bool CreateMessage(Messagesul messagesul)
        {
            var p = new DynamicParameters();
            p.Add("Subj", messagesul.Subject, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Msg", messagesul.Message, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("email1", messagesul.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("name1", messagesul.Name, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = DbContext.Connection.ExecuteAsync("MESSAGE_PACKAGE.CREATEMESSAGE", p, commandType: CommandType.StoredProcedure);
            return true;

        }

    }
}
