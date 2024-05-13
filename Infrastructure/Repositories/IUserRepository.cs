using Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUserRepository
    {
       List<User> GetUsers();
        Task<User> GetByIdAsync(int id);
       Task<User> AddUpdateUserAsync(User user);
        Task<bool> DeleteUserAsync(int id);
    }
}
