using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository _bookRepository)
        {
            this._bookRepository = _bookRepository;
        }
        public List<Bookul> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
        public bool CreateNewBook(Bookul book)
        {
            return _bookRepository.CreateNewBook(book);
        }
        public bool UpdateBook(Bookul book)
        {
            return _bookRepository.UpdateBook(book);
        }
        public bool DeleteBook(int id)
        {
            return _bookRepository.DeleteBook(id);
        }
    }
}
