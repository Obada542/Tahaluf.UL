using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.DTO
{
    public class ReportDTO
    {
        public string Bookname { get; set; }
        public float? Sales { get; set; }
        public int? Orders { get; set; }
        public float? Fines { get; set; }
        public string Period { get; set; }
    }
}
