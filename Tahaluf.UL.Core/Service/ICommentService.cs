using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;

namespace Tahaluf.UL.Core.Service
{
    public interface ICommentService
    {
        List<CommentUL> GetAllComment();

        bool CreateComment(CommentUL comment);

        bool UpdateComment(CommentUL comment);

        bool DeleteComment(int id);
    }
}
