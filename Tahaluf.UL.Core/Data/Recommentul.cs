using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Recommentul
    {
        [Key]
        public int Id { get; set; }
        public string StudentComment { get; set; }
        public int? CommentId { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Studentul Student { get; set; }
        [ForeignKey("CommentId")]
        public virtual Commentul Comment { get; set; }
    }
}
