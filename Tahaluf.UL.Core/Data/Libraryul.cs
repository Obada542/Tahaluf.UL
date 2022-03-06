using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public partial class Libraryul
    {
        public Libraryul()
        {
            Bookuls = new HashSet<Bookul>();
        }
        [Key]
        public int Id { get; set; }
        public string Library_Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<Bookul> Bookuls { get; set; }
    }
}
