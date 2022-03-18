using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public partial class Libraryul
    {
        public int Id { get; set; }
        public string Library_Name { get; set; }
        public string Location { get; set; }
        public string Image { get; set; }

    }
}
