using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class AccountantUL
    {
        [Key]
        public int Id { get; set; }

        public int Salary { get; set; }

        public string Address { get; set; }

        public int Login_Id { get; set; }
        [ForeignKey("Login_Id")]
        public virtual Loginul Login { get; set; }

    }
}
