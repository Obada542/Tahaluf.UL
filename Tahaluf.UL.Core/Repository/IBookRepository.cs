﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IBookRepository
    {
        List<Bookul> GetAllBooks();
        bool CreateNewBook(Bookul book);
        bool UpdateBook(Bookul book);
        bool DeleteBook(int id);

    }
}
