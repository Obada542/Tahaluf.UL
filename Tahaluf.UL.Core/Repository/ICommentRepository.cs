using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Repository
{
    public interface ICommentRepository
    {
        List<CommentUL> GetAllComment(int id);
        bool CreateComment(CommentUL comment);
        bool UpdateComment(CommentUL comment);
        bool DeleteComment(int id);

    }
}
