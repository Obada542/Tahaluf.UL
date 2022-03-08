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

        public List<Homeul> GetAllSliders()
        {
            return homeRepository.GetAllSliders();
        }

       public bool CreateSlider(Homeul home)
        {
            return homeRepository.CreateSlider(home);
        }

       public bool UpdateSlider(Homeul home)
        {
            return homeRepository.UpdateSlider(home);
        }

       public bool DeleteSlider(int id)
        {
            return homeRepository.DeleteSlider(id);
        }
    }
}
