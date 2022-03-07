using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
   public class AboutService : IAboutService
    {
        private readonly IAboutulRepository aboutulRepository;
        public AboutService(IAboutulRepository _aboutulRepository)
        {
            aboutulRepository = _aboutulRepository;
        }

       public List<Aboutul> GetAllAboutUl()
        {
            return aboutulRepository.GetAllAboutUl();
        }

        public bool CreateAboutUl(Aboutul about)
        {
            return aboutulRepository.CreateAbouttUl(about);
        }

        public bool UpdateAbouttUl(Aboutul about)
        {
            return aboutulRepository.UpdateAbouttUl(about);
        }
       public bool DeleteAbouttUl(string titl)
        {
            return aboutulRepository.DeleteAbouttUl(titl);
        }


    }
}
