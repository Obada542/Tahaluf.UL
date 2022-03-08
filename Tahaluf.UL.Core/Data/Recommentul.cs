using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class RecommentUL
    {
        public int Id { get; set; }
        public string Student_Comment { get; set; }
        public int Student_Id { get; set; }
        public int Comment_Id { get; set; }
    }
}
