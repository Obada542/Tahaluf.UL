using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.UL.Core.Data
{
    public class Homeul
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Sub_Title { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }
    }
}
