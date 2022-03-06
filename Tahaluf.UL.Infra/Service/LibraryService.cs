using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        public LibraryService(ILibraryRepository _libraryRepository)
        {
            this._libraryRepository = _libraryRepository;
        }
        public bool CreateNewLibrary(Libraryul library)
        {
            return _libraryRepository.CreateNewLibrary(library);
        }

        public bool DeleteLibrary(int id)
        {
            return _libraryRepository.DeleteLibrary(id);
        }

        public List<Libraryul> GetAllLibraries()
        {
            return _libraryRepository.GetAllLibraries();
        }

        public bool UpdateLibrary(Libraryul library)
        {
            return _libraryRepository.UpdateLibrary(library);
        }
        public List<Libraryul> GetLibraryByName(string name)
        {
            return _libraryRepository.GetLibraryByName(name);

        }
    }
}
