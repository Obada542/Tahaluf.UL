using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
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
        [ProducesResponseType(typeof(List<Libraryul>), StatusCodes.Status200OK)]
        [Route("GetLibraries")]
        public List<Libraryul> GetAllLibraries()
        {
            return _libraryService.GetAllLibraries();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Libraryul>), StatusCodes.Status200OK)]
        [Route("GetLibraries/{name}")]
        public List<Libraryul> GetLibraryByName(string name)
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

        [HttpGet]
        [ProducesResponseType(typeof(List<Libraryul>), StatusCodes.Status200OK)]
        [Route("LibrariesByLocation/{location}")]
        public List<Libraryul> GetLibraryByLocation(string location)
        {
            return _libraryService.GetLibraryByLocation(location);
        }
        [HttpPost]
        [Route("uploadImage")]
        public Libraryul UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine(@"C:\Users\obada\Tahaluf.UL.Angular\src\assets\Images", fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Libraryul Item = new Libraryul();
                Item.Image = fileName;
                return Item;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
