using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models
{
    public partial class User
    {
        public Domain.Models.User ToDomainModel()
        {
            return new Domain.Models.User
            {
                UserId = this.UserId,
                UserName = this.UserName,
                Cnic = this.Cnic,
                PhoneNumber = this.PhoneNumber
            };
        }
        public User FromDomainModel(Domain.Models.CreateUpdateUser user)
        {
            return new User
            {
                UserName = user.UserName,
                Cnic = user.Cnic,
                PhoneNumber = user.PhoneNumber
            };
        }
        public User FromDomainModel(Domain.Models.User user)
        {
            return new User
            {
                UserId = user.UserId,
                UserName = user.UserName,
                Cnic = user.Cnic,
                PhoneNumber = user.PhoneNumber
            };
        }
    }
}
