using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _IUserRepository;
        public UserService(IUserRepository iUserRepository)
        {
            _IUserRepository = iUserRepository;
        }   
        public List<Domain.Models.User> GetUsers()
        {
          return  _IUserRepository.GetUsers().Select(x => x.ToDomainModel()).ToList();
        }
        public async Task<Domain.Models.User> GetUserByIdAsync(int id)
        {
            Domain.Models.User user = new Domain.Models.User();
            Infrastructure.Models.User user1 = await _IUserRepository.GetByIdAsync(id);
            user = user1.ToDomainModel();
            return user;
        }
        public async Task<Domain.Models.User> AddUpdateUserAsync( Domain.Models.CreateUpdateUser user, int? id = null)
        {
            Domain.Models.User response = new Domain.Models.User();
            if (id == null)
            {
                Infrastructure.Models.User user1 = new Infrastructure.Models.User();
                user1 = user1.FromDomainModel(user);
                var resp = await _IUserRepository.AddUpdateUserAsync(user1);
                response = resp?.ToDomainModel();
            }
            else
            {
                Infrastructure.Models.User user1 = new Infrastructure.Models.User();
                user1 = user1.FromDomainModel(user);
                user1.UserId = id; 
                var resp = await _IUserRepository.AddUpdateUserAsync(user1);
                response = resp?.ToDomainModel();
            }

            return response;
            
        }
        public async Task<bool> DeleteUserAsync(int id)
        {
            
            var isRowChanged = await _IUserRepository.DeleteUserAsync(id);
            return isRowChanged;
        }
    }
}
