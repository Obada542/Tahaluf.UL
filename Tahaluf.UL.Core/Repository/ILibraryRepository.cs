using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface ILibraryRepository
    {
        List<Libraryul> GetAllLibraries();
        bool CreateNewLibrary(Libraryul library);
        bool UpdateLibrary(Libraryul library);
        bool DeleteLibrary(int id);
        Libraryul GetLibraryByName(string name);


    }
}
