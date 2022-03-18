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
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService _bookService)
        {
            this._bookService = _bookService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("GetBooks")]
        public List<Bookul> GetAllBooks()
        {
            return _bookService.GetAllBooks();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("Search/{name}")]
        public List<Bookul> SearchBook(string name)
        {
            return _bookService.SearchBook(name);
        }

        [HttpPost]
        [Route("CreateBook")]
        public bool CreateNewBook([FromBody]Bookul book)
        {
            return _bookService.CreateNewBook(book);
        }

        [HttpPut]
        [Route("UpdateBook")]
        public bool UpdateBook([FromBody] Bookul book)
        {
            return _bookService.UpdateBook(book);
        }

        [HttpDelete]
        [Route("DeleteBook/{id}")]
        public bool DeleteBook(int id)
        {
            return _bookService.DeleteBook(id);
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("SearchByLibrary/{name}")]
        public List<Bookul> GetAllBooksByLibrary(string name)
        {
            return _bookService.GetAllBooksByLibrary(name);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("getbestbooks")]
        public List<Bookul> GetBestBooks()
        {
            return _bookService.GetBestBooks();
        }
        [HttpPut]
        [Route("updatesold/{id}")]
        public bool UpdateBookSold(int id)
        {
            return _bookService.UpdateBookSold(id);
        }
        [HttpPost]
        [Route("uploadImage")]
        public Bookul UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_"
                + file.FileName;
                var fullPath = Path.Combine(@"C:\Users\obada\Tahaluf.UL.Angular\src\assets\Images", fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Bookul Item = new Bookul();
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
