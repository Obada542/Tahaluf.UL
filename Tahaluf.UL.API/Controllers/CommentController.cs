using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Tahaluf.UL.Core.Data;
using Tahaluf.UL.Core.Service;

namespace Tahaluf.UL.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService _commentService)
        {
            commentService = _commentService;
        }


        [HttpPost]
        public bool CreateComment([FromBody] CommentUL comment)
        {
            return commentService.CreateComment(comment);

        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteComment(int id)
        {
            return commentService.DeleteComment(id);
        }

        [HttpPut]
        public bool UpdateComment([FromBody] CommentUL comment)
        {
            return commentService.UpdateComment(comment);
        }

        [HttpGet]
        public List<CommentUL> GetAllComment()
        {
            return commentService.GetAllComment();
        }

    }
}
