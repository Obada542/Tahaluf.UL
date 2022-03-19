using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface INewsService
    {
        List<News> GetAllNews();
        bool CreateNews(News news);
        bool UpdateNews(News news);
        bool DeleteNews(int id);
    }
}
