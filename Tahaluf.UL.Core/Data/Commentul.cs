using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Commentul
    {
        public Commentul()
        {
            Recommentuls = new HashSet<Recommentul>();
        }
        [Key]
        public int Id { get; set; }
        public string StudentComment { get; set; }
        public int? BookId { get; set; }
        public int? StudentId { get; set; }
        [ForeignKey("BookId")]
        public virtual Bookul Book { get; set; }
        [ForeignKey("StudentId")]
        public virtual Studentul Student { get; set; }
        public virtual ICollection<Recommentul> Recommentuls { get; set; }
    }
}
