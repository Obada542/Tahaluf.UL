using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
   public class BackgrounduService : IBackgroundService
    {
        private readonly IBackgroundsulRepository backgroundsulRepository;

        public BackgrounduService (IBackgroundsulRepository _backgroundsulRepository)
        {
            backgroundsulRepository = _backgroundsulRepository;
        }

        public List<Backgroundsul> GetAllBackgroundUl()
        {
            return backgroundsulRepository.GetAllBackgroundUl();
        }

        public bool CreateBackgroungUl(Backgroundsul back)
        {
            return backgroundsulRepository.CreateBackgroungUl(back);
        }

      public  bool UpdateBackgroundUl(Backgroundsul back)
        {
            return backgroundsulRepository.UpdateBackgroundUl(back);
        }

        public bool DeleteBackgroundUl(string page)
        {
            return backgroundsulRepository.DeleteBackgroundUl(page);
        }

    }
}
