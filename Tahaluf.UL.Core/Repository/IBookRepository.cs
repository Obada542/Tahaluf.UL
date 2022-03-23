using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

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
        bool ChangeBookDiscount(float discount);
    }
}
