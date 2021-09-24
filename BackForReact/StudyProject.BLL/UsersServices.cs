using StudyProject.DAL;
using StudyProject.Doman;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudyProject.BLL
{
    public class UsersServices : IUsesrService
    {
        private IUserRepository _userRepository;

        public UsersServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task AddUser(Users user)
        {
            await _userRepository.AddUser(user);
        }

        public async Task<List<Users>> GetAllUsers()
        {
            return await _userRepository.GetAllUsers();
        }

        public async Task UpdateUser(List<Users> users)
        {
            foreach (var user in users)
            {
                await _userRepository.UpdateUser(user);
            }
        }
    }
}
