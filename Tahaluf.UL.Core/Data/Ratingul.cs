using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable
namespace Tahaluf.UL.Core.Data

{
    public class Ratingul
    {
        [Key]
        public int Id { get; set; }
        public float? Rate { get; set; }
        public int? Book_Id { get; set; }
        public int? Student_Id { get; set; }

        [ForeignKey("Book_Id")]
        public virtual Bookul Book { get; set; }
        [ForeignKey("Student_Id")]
        public virtual StudentUL Student { get; set; }
    }
}
