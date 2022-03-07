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
   public class ContactulRepository : IContactulRepository
    {
        private readonly IDbContext DbContext;

        public ContactulRepository(IDbContext _DbContext)
        {
            DbContext = _DbContext;
        }

        public List<Contactul> GetAllContactUl()
        {
            IEnumerable<Contactul> result = DbContext.Connection.Query<Contactul>("CONTACTUL_PACKAGE.GETALLCONTACTUL", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool CreateContactUl(Contactul contact)
        {
            var p = new DynamicParameters();
            p.Add("contact_Title", contact.TITLE, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_Contact_Title", contact.Sub_Title, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DESCRP", contact.Description, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("MAIL", contact.Email, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Phone_Numbers", contact.Numbers, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Adress", contact.Addresses, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("CONTACTUL_PACKAGE.CREATECONTACTUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }


       public bool UpdateContactUl(Contactul contact)
        {
            var p = new DynamicParameters();
            p.Add("contact_Title", contact.TITLE, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("sub_Contact_Title", contact.Sub_Title, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("DESCRP", contact.Description, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("MAIL", contact.Email, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("Phone_Numbers", contact.Numbers, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("Adress", contact.Addresses, dbType: DbType.String, direction: ParameterDirection.Input);


            var result = DbContext.Connection.ExecuteAsync("CONTACTUL_PACKAGE.UPDATECONTACTUL", p, commandType: CommandType.StoredProcedure);
            return true;
        }

         public bool DeleteContactUl(string mobile)
        {
            var p = new DynamicParameters();
            p.Add("Phone_Numbers", mobile , dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = DbContext.Connection.ExecuteAsync("CONTACTUL_PACKAGE.DELETECONTACTUL", p , commandType: CommandType.StoredProcedure);
            return true;
        }



    }
}
