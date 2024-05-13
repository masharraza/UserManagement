using System;
using System.Collections.Generic;

namespace Infrastructure.Models
{
    public partial class User
    {
        public int? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Cnic { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
