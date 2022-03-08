using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
   public class HomeService : IHomeService
    {
        private readonly IHomeRepository homeRepository;
        public HomeService(IHomeRepository _homeRepository)
        {
            homeRepository = _homeRepository;
        }

        public List<Homeul> GetAllHomeul()
        {
            return homeRepository.GetAllHomeul();
        }

       public bool CreateHomeul(Homeul hom)
        {
            return homeRepository.CreateHomeul(hom);
        }

       public bool UpdateHomeul(Homeul hom)
        {
            return homeRepository.UpdateHomeul(hom);
        }

       public bool DeleteHomeul(int id)
        {
            return homeRepository.DeleteHomeul(id);
        }

    }
}
