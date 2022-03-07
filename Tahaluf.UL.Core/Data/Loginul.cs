using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Loginul
    {
        public Loginul()
        {
            Accountantuls = new HashSet<AccountantUL>();
            Studentuls = new HashSet<StudentUL>();
        }
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }
        public DateTime? Birthday { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
        public int? Role_Id { get; set; }
        [ForeignKey("Role_Id")]
        public virtual Roleul Role { get; set; }
        public virtual ICollection<AccountantUL> Accountantuls { get; set; }
        public virtual ICollection<StudentUL> Studentuls { get; set; }
    }
}
