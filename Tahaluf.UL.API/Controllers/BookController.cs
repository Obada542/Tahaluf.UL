using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
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
        [ProducesResponseType(typeof(Bookul), StatusCodes.Status200OK)]
        [Route("GetBookById/{id}")]
        public Bookul GetBookById(int id)
        {
            return _bookService.GetBookById(id);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("getbestbooks")]
        public List<Bookul> GetBestBooks()
        {
            return _bookService.GetBestBooks();
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("GetAvailableBook")]
        public List<Bookul> GetAvailableBook()
        {
            return _bookService.GetAvailableBook();
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Category>), StatusCodes.Status200OK)]
        [Route("GetCategories")]
        public List<Category> GetCategories()
        {
            return _bookService.GetCategories();
        }
        [HttpPut]
        [Route("updatesold/{id}")]
        public bool UpdateBookSold(int id)
        {
            return _bookService.UpdateBookSold(id);
        }
        [HttpPut]
        [Route("ChangeBookDiscount")]
        public bool ChangeBookDiscount([FromBody] float discount)
        {
            return _bookService.ChangeBookDiscount(discount);
        }
        [HttpGet]
        [ProducesResponseType(typeof(List<Bookul>), StatusCodes.Status200OK)]
        [Route("GetNewestBooks")]
        public List<Bookul> GetNewestBooks()
        {
            return _bookService.GetNewestBooks();
        }
        [HttpPost]
        [Route("uploadImage")]
        public Bookul UploadImage()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_"+ file.FileName;
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
        [HttpPost]
        [Route("uploadPdf")]
        public Bookul UploadPdf()
        {
            try
            {
                var file = Request.Form.Files[0];
                var fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                var fullPath = Path.Combine(@"C:\Users\obada\Tahaluf.UL.Angular\src\assets\books", fileName);
                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                Bookul Item = new Bookul();
                Item.Pdf = fileName;
                return Item;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }

}
