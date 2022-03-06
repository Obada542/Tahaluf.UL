using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class Accountantul
    {
        [Key]
        public int Id { get; set; }
        public float? Salary { get; set; }
        public string Address { get; set; }
        public int? LoginId { get; set; }
        [ForeignKey("LoginId")]
        public virtual Loginul Login { get; set; }
    }
}
