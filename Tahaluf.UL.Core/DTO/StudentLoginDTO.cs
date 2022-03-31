using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.UL.Core.DTO
{
    public class StudentLoginDTO
    {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public int Login_Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime? Birthday { get; set; }
        public string Image { get; set; }
        public string Password { get; set; }
    }
}
