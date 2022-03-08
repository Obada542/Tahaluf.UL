using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Tahaluf.UL.Core.Data

{
    public class Messagesul
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
