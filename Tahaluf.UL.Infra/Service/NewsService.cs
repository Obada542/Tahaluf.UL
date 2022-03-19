using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class NewsService : INewsService
    {
        private readonly INewsRepository _newsRepository;
        public NewsService(INewsRepository _newsRepository)
        {
            this._newsRepository = _newsRepository;
        }

        public bool CreateNews(News news)
        {
            return _newsRepository.CreateNews(news);
        }

        public bool DeleteNews(int id)
        {
            return _newsRepository.DeleteNews(id);
        }

        public List<News> GetAllNews()
        {
            return _newsRepository.GetAllNews();
        }

        public bool UpdateNews(News news)
        {
            return _newsRepository.UpdateNews(news);
        }
    }
}
