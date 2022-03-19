using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.Data
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public DateTime? Published { get; set; }

    }
}
