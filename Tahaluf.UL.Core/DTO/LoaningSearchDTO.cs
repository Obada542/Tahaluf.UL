using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.DTO
{
    public class LoaningSearchDTO
    {
        public string Book_Name { get; set; }
        public string Student_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string Isloaned { get; set; }
        public float? Fines { get; set; }
    }
}
