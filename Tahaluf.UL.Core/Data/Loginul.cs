using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class Loginul
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public int? Role_Id { get; set; }
        public virtual Roleul Role { get; set; }
    }
}
