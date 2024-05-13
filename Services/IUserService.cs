using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IUserService
    {
        List<Domain.Models.User> GetUsers();
        Task<Domain.Models.User> GetUserByIdAsync(int id);
        Task<Domain.Models.User> AddUpdateUserAsync( Domain.Models.CreateUpdateUser user, int? id = null);
        Task<bool> DeleteUserAsync(int id);
    }
}
