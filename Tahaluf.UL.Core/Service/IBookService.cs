using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IBookService
    {
        List<Bookul> GetAllBooks();
        List<Bookul> GetAllBooksByLibrary(string name);

        bool CreateNewBook(Bookul book);
        bool UpdateBook(Bookul book);
        bool DeleteBook(int id);
        List<Bookul> SearchBook(string name);
        bool UpdateBookSold(int id);
        List<Bookul> GetBestBooks();

    }
}
