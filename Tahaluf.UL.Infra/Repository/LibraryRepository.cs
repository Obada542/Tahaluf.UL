using System;
using Dapper;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Common;
using System.Data;
using System.Linq;

namespace Tahaluf.UL.Infra.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        private readonly IDbContext _dbContext;
        public LibraryRepository(IDbContext _dbContext)
        {
            this._dbContext = _dbContext;
        }
        public List<Libraryul> GetAllLibraries()
        {
            var libraries = _dbContext.Connection.Query<Libraryul>("LIBRARY_PACKAGE.GETLIBRARIES", commandType:CommandType.StoredProcedure);

            return libraries.ToList();
        }
        public bool CreateNewLibrary(Libraryul library)
        {
            var p = new DynamicParameters();
            p.Add("NAME",library.Library_Name,dbType:DbType.String,direction:ParameterDirection.Input);
            p.Add("LOCA", library.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PIC", library.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var newlibrary = _dbContext.Connection.ExecuteAsync("LIBRARY_PACKAGE.CREATELIBRARY", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateLibrary(Libraryul library)
        {
            var p = new DynamicParameters();
            p.Add("LIB_ID", library.Id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("NAME", library.Library_Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("LOCA", library.Location, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("PIC", library.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            var newlibrary = _dbContext.Connection.ExecuteAsync("LIBRARY_PACKAGE.UPDATELIBRARY", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteLibrary(int id)
        {
            var p = new DynamicParameters();
            p.Add("LIB_ID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var newlibrary = _dbContext.Connection.ExecuteAsync("LIBRARY_PACKAGE.DELETELIBRARY", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public List<Libraryul> GetLibraryByName(string name)
        {
            var p = new DynamicParameters();
            p.Add("NAME", name, dbType: DbType.String, direction: ParameterDirection.Input);
            var library = _dbContext.Connection.Query<Libraryul>("LIBRARY_PACKAGE.getlibrarybyname", p, commandType: CommandType.StoredProcedure);
            return library.ToList();
        }
        public List<Libraryul> GetLibraryByLocation(string location)
        {
            var p = new DynamicParameters();
            p.Add("LOCA", location, dbType: DbType.String, direction: ParameterDirection.Input);
            var library = _dbContext.Connection.Query<Libraryul>("LIBRARY_PACKAGE.getlibrarybylocation", p, commandType: CommandType.StoredProcedure);
            return library.ToList();
        }

    }
}
