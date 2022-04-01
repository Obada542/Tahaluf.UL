using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable
namespace Tahaluf.UL.Core.Data

{
    public class Ratingul    
    {
        public int Id { get; set; }
        public float? Rate { get; set; }
        public string Review { get; set; }
        public DateTime? Daterate { get; set; }

        public int? Book_Id { get; set; }
        public int? Student_Id { get; set; }
    }
}
