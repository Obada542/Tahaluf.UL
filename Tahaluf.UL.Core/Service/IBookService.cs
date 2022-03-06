using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IBookService
    {
        List<Bookul> GetAllBooks();
        bool CreateNewBook(Bookul book);
        bool UpdateBook(Bookul book);
        bool DeleteBook(int id);

    }
}
