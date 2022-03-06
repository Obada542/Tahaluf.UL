using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private readonly ILibraryService _libraryService;
        public LibraryController(ILibraryService _libraryService)
        {
            this._libraryService = _libraryService;
        }
        [HttpGet]
        [Route("GetLibraries")]
        public List<Libraryul> GetAllLibraries()
        {
            return _libraryService.GetAllLibraries();
        }
        [HttpGet]
        [Route("GetLibraries/{name}")]
        public Libraryul GetLibraryByName(string name)
        {
            return _libraryService.GetLibraryByName(name);
        }
        [HttpPost]
        [Route("CreateLibrary")]
        public bool CreateLibrary([FromBody] Libraryul library)
        {
            return _libraryService.CreateNewLibrary(library);
        }
        [HttpPut]
        [Route("UpdateLibrary")]
        public bool UpdateLibrary([FromBody] Libraryul library)
        {
            return _libraryService.UpdateLibrary(library);
        }
        [HttpDelete]
        [Route("DeleteLibrary/{id}")]
        public bool DeleteLibrary(int id)
        {
            return _libraryService.DeleteLibrary(id);
        }
    }
}
