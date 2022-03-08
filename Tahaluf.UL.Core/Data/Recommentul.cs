using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class RecommentUL
    {
        [Key]
        public int Id { get; set; }

        public string Student_Comment { get; set; }

        public int Student_Id { get; set; }
        [ForeignKey("Student_Id")]
        public virtual StudentUL Student { get; set; }

        public int Comment_Id { get; set; }
        [ForeignKey("Comment_Id")]
        public virtual CommentUL Comment { get; set; }
    }
}
