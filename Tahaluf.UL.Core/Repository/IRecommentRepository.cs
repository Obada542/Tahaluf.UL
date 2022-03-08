using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface IRecommentRepository
    {
        List<RecommentUL> GetAllRecomment();
        bool CreateRecomment(RecommentUL recomment);
        bool UpdateRecomment(RecommentUL recomment);
        bool DeleteRecomment(int id);
    }
}
