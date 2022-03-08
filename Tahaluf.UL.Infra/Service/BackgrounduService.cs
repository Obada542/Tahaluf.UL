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

        public List<Backgroundsul> GetAllBackgrounds()
        {
            return backgroundsulRepository.GetAllBackgrounds();
        }

        public bool CreateBackground(Backgroundsul back)
        {
            return backgroundsulRepository.CreateBackground(back);
        }

      public  bool UpdateBackground(Backgroundsul back)
        {
            return backgroundsulRepository.UpdateBackground(back);
        }
    }
}
