using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public partial class StudentUL
    {
        public StudentUL()
        {
            commentULs = new HashSet<CommentUL>();
            Loaninguls = new HashSet<Loaningul>();
            Ratinguls = new HashSet<Ratingul>();
            recommentULs = new HashSet<RecommentUL>();
        }
        [Key]
        public int Id { get; set; }

        public string First_Name { get; set; }

        public string Last_Name { get; set; }

        public int Login_Id { get; set; }
        [ForeignKey("Login_Id")]
        public virtual Loginul Login { get; set; }

        public ICollection<CommentUL> commentULs { get; set; }
        public ICollection<RecommentUL> recommentULs { get; set; }
        public virtual ICollection<Loaningul> Loaninguls { get; set; }
        public virtual ICollection<Ratingul> Ratinguls { get; set; }

    }
}
