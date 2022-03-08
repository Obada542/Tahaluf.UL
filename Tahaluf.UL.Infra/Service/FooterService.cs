using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class FooterService : IFooterService
    {
        private readonly IFooterRepository footerRepository;
        public FooterService(IFooterRepository _footerRepository)
        {
            footerRepository = _footerRepository;
        }

        public Footerul GetFooterul(Footerul foter)

        {
            return footerRepository.GetFooterul(foter);
        }



        public bool UpdateFooterul(Footerul foter)
        {
            return footerRepository.UpdateFooterul(foter);
        }


    }

    
}
