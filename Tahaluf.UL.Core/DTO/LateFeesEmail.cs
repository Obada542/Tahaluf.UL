using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.DTO
{
    public class LateFeesEmail
    {
        public string Name { get; set; }
        public string Book_Name { get; set; }
        public string Email { get; set; }
        public DateTime? End_Date { get; set; }
        public DateTime? Start_Date { get; set; }
        public float? Fines { get; set; }
        public float? Discount { get; set; }

    }
}
