using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class HeaderService: IHeaderService
    {
        private readonly IHeaderRepository headerRepository;

        public HeaderService(IHeaderRepository _headerRepository)
        {
            headerRepository = _headerRepository;
        }


        public Headerul GetHeader()
        {
            return headerRepository.GetHeader();
        }

        public bool CreateHeader(Headerul headerul)
        {
            return headerRepository.CreateHeader(headerul);

        }

        public bool UpdateHeader(Headerul headerul)
        {
            return headerRepository.UpdateHeader(headerul);

        }

        public string DeleteHeader()
        {
            return headerRepository.DeleteHeader();

        }
    }
}
