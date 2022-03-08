using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class AccountantUL
    {
        public int Id { get; set; }
        public int Salary { get; set; }
        public string Address { get; set; }
        public int Login_Id { get; set; }
    }
}
