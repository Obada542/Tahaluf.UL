using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface IRecommentService
    {
        List<RecommentUL> GetAllRecomment(int id);

        bool CreateRecomment(RecommentUL recomment);

        bool UpdateRecomment(RecommentUL recomment);

        bool DeleteRecomment(int id);
    }
}
