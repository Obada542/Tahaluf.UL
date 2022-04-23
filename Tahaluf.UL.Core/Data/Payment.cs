using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.Data
{
    public class Payment
    {
        public string Card_Number {get;set;}
        public int? Cvv { get;set;}
        public float? Amount { get; set; }
        public string Expired_Date { get; set; }

    }
}
