using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Loaningul
    {
        [Key]
        public int Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Isloaned { get; set; }
        public float? Fines { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("BookId")]
        public virtual Bookul Book { get; set; }
        [ForeignKey("StudentId")]
        public virtual Studentul Student { get; set; }
    }
}
