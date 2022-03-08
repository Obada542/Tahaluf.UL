using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Repository;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.Infra.Service
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }



        public bool CreateComment(CommentUL comment)
        {
            return _commentRepository.CreateComment(comment);
        }

        public bool DeleteComment(int id)
        {
            return _commentRepository.DeleteComment(id);
        }

        public List<CommentUL> GetAllComment()
        {
            return _commentRepository.GetAllComment();
        }

        public bool UpdateComment(CommentUL comment)
        {
            return _commentRepository.UpdateComment(comment);
        }
    }
}
