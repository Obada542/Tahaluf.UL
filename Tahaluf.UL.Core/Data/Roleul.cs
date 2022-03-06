using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Roleul
    {
        public Roleul()
        {
            Loginuls = new HashSet<Loginul>();
        }
        [Key]
        public int Id { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<Loginul> Loginuls { get; set; }
    }
}
