using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class Loaningul
    {
        public int Id { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string Isloaned { get; set; }
        public float? Fines { get; set; }
        public int? Book_Id { get; set; }
        public int? Student_Id { get; set; }
        public virtual Bookul Book { get; set; }
        public virtual StudentUL Student { get; set; }
    }
}
