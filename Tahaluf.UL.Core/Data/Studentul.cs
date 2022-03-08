using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public partial class StudentUL
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Login_Id { get; set; }
        public virtual Loginul Login { get; set; }
    }
}
