using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class CreateUpdateUser
    {
        public string? UserName { get; set; }
        public string? Cnic { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
