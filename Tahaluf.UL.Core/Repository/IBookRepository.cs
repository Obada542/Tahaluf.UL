using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.DTO;

namespace Tahaluf.UL.Core.Repository
{
    public interface IBookRepository
    {
        List<Bookul> GetAllBooks();
        List<Bookul> GetAllBooksByLibrary(string name);
        bool CreateNewBook(Bookul book);
        bool UpdateBook(Bookul book);
        bool DeleteBook(int id);
        List<Bookul> SearchBook(string name);
        bool UpdateBookSold(int id);
        List<Bookul> GetBestBooks();
        List<Bookul> GetNewestBooks();
        bool ChangeBookDiscount(float discount);
        List<Bookul> GetAvailableBook();
        List<Category> GetCategories();
        Bookul GetBookById(int id);

    }
}
