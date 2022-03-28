using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;
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
        public List<Bookul> SearchBook(string name)
        {
            return _bookRepository.SearchBook(name);

        }
        public List<Bookul> GetAllBooksByLibrary(string name)
        {
            return _bookRepository.GetAllBooksByLibrary(name);
        }
        public bool UpdateBookSold(int id)
        {
            return _bookRepository.UpdateBookSold(id);
        }
        public List<Bookul> GetBestBooks()
        {
            return _bookRepository.GetBestBooks();
        }
        public bool ChangeBookDiscount(float discount)
        {
            return _bookRepository.ChangeBookDiscount(discount);
        }

        public List<Bookul> GetAvailableBook()
        {
            return _bookRepository.GetAvailableBook();
        }

        public List<Category> GetCategories()
        {
            return _bookRepository.GetCategories();
        }
        public List<Bookul> GetNewestBooks()
        {
            return _bookRepository.GetNewestBooks();
        }

        public Bookul GetBookById(int id)
        {
            return _bookRepository.GetBookById(id);
        }
    }
}
