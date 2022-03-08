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

        public Footerul GetFooter()

        {
            return footerRepository.GetFooter();
        }

        public bool UpdateFooter(Footerul footer)
        {
            return footerRepository.UpdateFooter(footer);
        }
    }
}
