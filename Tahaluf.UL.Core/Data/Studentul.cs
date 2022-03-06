using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public partial class Studentul
    {
        public Studentul()
        {
            Commentuls = new HashSet<Commentul>();
            Loaninguls = new HashSet<Loaningul>();
            Ratinguls = new HashSet<Ratingul>();
            Recommentuls = new HashSet<Recommentul>();
        }
        [Key]
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int? Login_Id { get; set; }
        [ForeignKey("Login_Id")]
        public virtual Loginul Login { get; set; }
        public virtual ICollection<Commentul> Commentuls { get; set; }
        public virtual ICollection<Loaningul> Loaninguls { get; set; }
        public virtual ICollection<Ratingul> Ratinguls { get; set; }
        public virtual ICollection<Recommentul> Recommentuls { get; set; }
    }
}
