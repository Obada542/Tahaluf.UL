using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class RecommentService : IRecommentService
    {
        private readonly IRecommentRepository _RecommentRepository;

        public RecommentService(IRecommentRepository RecommentRepository)
        {
            _RecommentRepository = RecommentRepository;
        }
        public bool CreateRecomment(RecommentUL recomment)
        {
            return _RecommentRepository.CreateRecomment(recomment);
        }
        public bool DeleteRecomment(int id)
        {
            return _RecommentRepository.DeleteRecomment(id);
        }
        public List<RecommentUL> GetAllRecomment(int id)
        {
            return _RecommentRepository.GetAllRecomment(id);
        }

        public bool UpdateRecomment(RecommentUL recomment)
        {
            return _RecommentRepository.UpdateRecomment(recomment);
        }
    }
}
