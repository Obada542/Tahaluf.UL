using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface INewsRepository
    {
        List<News> GetAllNews();
        bool CreateNews(News news);
        bool UpdateNews(News news);
        bool DeleteNews(int id);

    }
}
