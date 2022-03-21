using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.DTO
{
    public class StudentLoaningDTO
    {
        public string Book_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public float? Fines { get; set; }
        public float? Price { get; set; }
        public string Image { get; set; }
        public string Library_name { get; set; }
        public string Location { get; set; }
        public float? Discount { get; set; }
    }
}
