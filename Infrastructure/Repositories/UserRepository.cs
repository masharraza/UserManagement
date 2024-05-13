using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManagementSystemContext _userManagementSystemContext;
        public UserRepository(UserManagementSystemContext userManagementSystemContext)
        {
            _userManagementSystemContext = userManagementSystemContext;
        }
        public List<User> GetUsers()
        {
            return _userManagementSystemContext.Users.ToList();
        }
        public async Task<User> GetByIdAsync(int id)
        {
            return await _userManagementSystemContext.Users.AsNoTracking().FirstOrDefaultAsync(g => g.UserId == id);
        }
        public async Task<User> AddUpdateUserAsync(User user)
        {
            int? id = user.UserId;
            var currUser = await _userManagementSystemContext.Users.AsNoTracking().FirstOrDefaultAsync(g => g.UserId == id);
            if (currUser != null)
            {
                _userManagementSystemContext.Add(user);
                _userManagementSystemContext.Attach(user);
                _userManagementSystemContext.Entry(user).State = EntityState.Modified;

            }
            else
            {
               await _userManagementSystemContext.Users.AddAsync(user);
            }
            int rowsChanged = await _userManagementSystemContext.SaveChangesAsync();
            if(rowsChanged > 0)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            User user = await _userManagementSystemContext.Users.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == id);

            _userManagementSystemContext.Users.Remove(user);

            int rowsChanged = await _userManagementSystemContext.SaveChangesAsync();

            if (rowsChanged > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
