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
        public int? BookId { get; set; }
        public int? StudentId { get; set; }

        [ForeignKey("BookId")]
        public virtual Bookul Book { get; set; }
        [ForeignKey("StudentId")]
        public virtual Studentul Student { get; set; }
    }
}
