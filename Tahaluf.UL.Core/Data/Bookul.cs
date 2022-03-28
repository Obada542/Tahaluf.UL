using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Bookul
    {
        public int Id { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public DateTime? Published_Date { get; set; } 
        public double? Price { get; set; }
        public string Overview { get; set; }
        public int? Quantity { get; set; }
        public double? Discount { get; set; }
        public string Image { get; set; }
        public int? Nosold { get; set; }
        public int? Library_Id { get; set; }
        public string Category { get; set; }
        public string Pdf { get; set; }
    }
}
